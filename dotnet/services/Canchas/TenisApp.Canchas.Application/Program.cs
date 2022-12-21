using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using MassTransit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TenisApp.Canchas.Persistence;
using TenisApp.Canchas.Persistence.Repository;

namespace TenisApp.Canchas.Application
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await CreateHostBuilder(args).Build().RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddMassTransit(x =>
                    {
                        x.SetKebabCaseEndpointNameFormatter();

                        // By default, sagas are in-memory, but should be changed to a durable
                        // saga repository.
                        x.SetInMemorySagaRepositoryProvider();

                        var entryAssembly = Assembly.GetEntryAssembly();
                        x.UsingInMemory((context, cfg) => { cfg.ConfigureEndpoints(context); });

                        x.AddConsumer<CreateOrUpdateCanchaConsumer, CreateOrUpdateCanchaConsumerDefinition>();
                    });

                    services.AddDbContext<CanchasDbContext>(options =>
                        options.UseSqlServer(
                            "Server=localhost;Database=master;Trusted_Connection=True;TrustServerCertificate=True;User=sa;Password=devpassword(!)001",
                            assembly => assembly.MigrationsAssembly(typeof(CanchasDbContext).Assembly.FullName)));

                    services.AddScoped<ICanchaRepository, CanchaRepository>();
                });
    }
}
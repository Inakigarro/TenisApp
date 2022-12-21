using System.Threading.Tasks;
using MassTransit;
using Microsoft.Extensions.Logging;
using TenisApp.Canchas.Contracts;
using TenisApp.Canchas.Domain.Entities;
using TenisApp.Canchas.Persistence.Repository;

namespace TenisApp.Canchas.Application
{
    public class CreateOrUpdateCanchaConsumer : IConsumer<CreateOrUpdateCancha>
    {
        private readonly ILogger<CreateOrUpdateCanchaConsumer> _logger;
        private readonly ICanchaRepository _canchaRespository;
        
        public CreateOrUpdateCanchaConsumer(ILogger<CreateOrUpdateCanchaConsumer> logger, ICanchaRepository canchaRespository)
        {
            this._logger = logger;
            this._canchaRespository = canchaRespository;
        }
        
        public async Task Consume(ConsumeContext<CreateOrUpdateCancha> context)
        {
            var data = context.Message;
            
            // Vamos a buscar si la cancha ya existe.
            var cancha = await _canchaRespository.GetCanchaByCorrelationId(data.CorrelationId);

            if (cancha == null)
            {
                cancha = new Cancha(data.CorrelationId);
                _logger.LogDebug("Creando una nueva cancha");
                cancha = await _canchaRespository.AddCancha(cancha);
            }
            
            _logger.LogDebug("Actualizando informacion de la cancha.");
            cancha.SetCode(data.Code);

            cancha = await _canchaRespository.UpdateCancha(cancha);

            await context.Publish<CanchaUpdated>(new
            {
                CorrelationId = cancha.CorrelationId,
                Code = cancha.Code,
                Turnos = cancha.Turnos,
                Habilitada = cancha.Habilitada,
            });
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TenisApp.Canchas.Domain.Entities;

namespace TenisApp.Canchas.Persistence.Repository;

public class CanchaRepository : ICanchaRepository
{
    private readonly CanchasDbContext _dbContext;
    private readonly ILogger<CanchaRepository> _logger;

    public CanchaRepository(CanchasDbContext dbContext, ILogger<CanchaRepository> logger)
    {
        _dbContext = dbContext;
        _logger = logger;
    }


    public async Task<Cancha?> GetCanchaByCorrelationId(Guid correlationId)
    {
        await using (_dbContext)
        {
            var cancha = await _dbContext.Canchas.FindAsync(correlationId);

            if (cancha == null)
            {
                _logger.LogError("No existe una cancha con el correlationId: {correlationId}", correlationId);
                throw new InvalidOperationException($"No existe una cancha con el correlationId {correlationId}");
            }

            return cancha;
        }
    }

    public async Task<Cancha> AddCancha(Cancha nuevaCancha)
    {
        await using (_dbContext)
        {
            var cancha = new Cancha();
            cancha.SetCode(nuevaCancha.Code);

            await _dbContext.Canchas.AddAsync(cancha);
            var result = await _dbContext.SaveChangesAsync();

            if (result != 1)
            {
                throw new InvalidOperationException("Ha ocurrido un error mientras se creaba una nueva cancha");
            }

            return cancha;
        }
    }

    public async Task<Cancha> UpdateCancha(Cancha updateCancha)
    {
        await using (_dbContext)
        {
            var cancha = await _dbContext.Canchas.FindAsync(updateCancha.CorrelationId);

            if (cancha == null)
            {
                throw new InvalidOperationException($"No existe una cancha con el correlation id {cancha.CorrelationId}.");
            }
            
            cancha.SetCode(updateCancha.Code);
            cancha.Turnos.AddRange(updateCancha.Turnos);

            await _dbContext.SaveChangesAsync();

            return cancha;
        }
    }

    public async Task<IEnumerable<Cancha>> GetAllCanchas()
    {
        await using (_dbContext)
        {
            var canchas = await _dbContext.Canchas.ToListAsync();
            return canchas;
        }
    }
}
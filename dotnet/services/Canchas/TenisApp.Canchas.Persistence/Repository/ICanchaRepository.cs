using TenisApp.Canchas.Domain.Entities;

namespace TenisApp.Canchas.Persistence.Repository;

public interface ICanchaRepository
{
    /// <summary>
    /// Obtiene una cancha por su Correlation Id.
    /// </summary>
    /// <param name="correlationId">CorrelationId de la cancha.</param>
    /// <returns>Devuelve la cancha correspondiente al CorrelationId dado.</returns>
    public Task<Cancha?> GetCanchaByCorrelationId(Guid correlationId);

    /// <summary>
    /// Agrega una cancha a la base de datos.
    /// </summary>
    /// <param name="cancha">La cancha que se va a agregar.</param>
    /// <returns></returns>
    public Task<Cancha> AddCancha(Cancha cancha);

    /// <summary>
    /// Actualiza los datos de una cancha en la base de datos.
    /// </summary>
    /// <param name="cancha">La cancha a actualizar.</param>
    /// <returns>La cancha actualizada.</returns>
    public Task<Cancha> UpdateCancha(Cancha cancha);

    /// <summary>
    /// Obtiene todas las canchas de la base de datos.
    /// </summary>
    /// <returns>Un IEnumerable de canchas.</returns>
    public Task<IEnumerable<Cancha>> GetAllCanchas();
}
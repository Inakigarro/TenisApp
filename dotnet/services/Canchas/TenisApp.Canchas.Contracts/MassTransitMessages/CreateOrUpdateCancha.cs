namespace TenisApp.Canchas.Contracts;

/// <summary>
/// Mensaje utilizado para crear o actualizar una Cancha.
/// </summary>
public record CreateOrUpdateCancha
{
    /// <summary>
    /// Obtiene o establece el Correlation Id de una Cancha.
    /// </summary>
    public Guid CorrelationId { get; set; }

    /// <summary>
    /// Obtiene o establece el Codigo de una Cancha.
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// Obtiene o establece la lista de turnos de una cancha.
    /// </summary>
    public IEnumerable<Guid> Turnos { get; set; } = null!;

    /// <summary>
    /// Obtiene o establece un valor que indica si la cancha esta habilidad o no.
    /// </summary>
    public bool Habilitada { get; set; } = true;
}
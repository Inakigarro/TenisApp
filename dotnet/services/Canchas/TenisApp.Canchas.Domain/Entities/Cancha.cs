using MassTransit;

namespace TenisApp.Canchas.Domain.Entities;

public class Cancha
{
    public Guid CorrelationId { get; set; }

    public string Code { get; private set; } = null!;

    public List<Guid> Turnos { get; } = null!;

    public bool Habilitada { get; set; } = true;

    public Cancha(Guid correlationId)
    {
        CorrelationId = correlationId;
    }

    public Cancha()
    {
        
    }

    public void SetCode(string code)
    {
        if (code == string.Empty)
        {
            throw new ArgumentNullException("El codigo de una cancha no puede ser null ni estar vacio.");
        }

        this.Code = code;
    }

    /// <summary>
    /// Cambia el estado de habilitacion de la cancha.
    /// </summary>
    public void CambiarHabilitacion()
    {
        this.Habilitada = !this.Habilitada;
    }
}
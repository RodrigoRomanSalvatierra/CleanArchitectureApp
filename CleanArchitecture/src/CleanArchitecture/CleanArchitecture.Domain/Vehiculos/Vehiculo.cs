using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Vehiculos;

// principio de responsabilidad unica
// sealed = no permitira que esta clase sea heredada por otra clase
public sealed class Vehiculo : Entity
{
    // Entidad en Domain Driver Design : 
    // 1 debe tener un identificador unico de clase, 
    // 2 debe ser continua es decir tiene que ser importante en la vida de la app
    // : base > defino constructor que llama al constructor del padre Entity
    public Vehiculo(Guid id) : base(id){} // el identificador sera unico
    public string? Modelo {get; private set;}
    public string? Vin {get; private set;}
    public Direccion Direccion {get; private set;}
    public decimal Precio {get; private set;}
    public string? TipoMoneda {get; private set;}
    public decimal Mantenimiento {get; private set;}
    public string? MantenimientoTipoMoneda {get; private set;}
    public Datetime? FechaUltimoAlquiler {get; private set;}
    public List<Accesorio> Accesorios {get; private set;} = new();
}
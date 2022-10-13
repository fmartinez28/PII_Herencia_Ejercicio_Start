using Library;

public class Pasajero : Usuario
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Cedula { get; set; }
    protected Rating Calificacion { get; set; }

    public override Rating GetCalificacion()
    {
        return Calificacion;
    }

    public override void Calificar(Rating qualif)
    {
        this.Calificacion = qualif;
    }

    public Pasajero(string Nombre, string Apellido, string Cedula)
    {
        this.Nombre = Nombre;
        this.Apellido = Apellido;
        this.Cedula = Cedula;
    }
}

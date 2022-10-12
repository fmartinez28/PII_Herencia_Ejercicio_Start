namespace Library;

public abstract class Usuario
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Cedula { get; set; }

    public enum Rating
    {
        Deficiente,
        Regular,
        Bueno,
        MuyBueno,
        Sobresaliente
    };

    protected Rating Calificacion { get; set; }

    public abstract string GetCalificacion();
}
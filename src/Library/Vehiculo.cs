namespace Library;

public class Vehiculo {
    public string Marca {get; set;}
    public string Modelo {get; set;}
    public int Año {get; set;}
    public string Color {get; set;}
    public string Matricula {get; set;}
    public int CapacidadMaxima {get; set;}

    public Vehiculo(string Marca, string Modelo, int Año, string Color, string Matricula, int CapacidadMaxima) {
        this.Marca = Marca;
        this.Modelo = Modelo;
        this.Año = Año;
        this.Color = Color;
        this.Matricula = Matricula;
        this.CapacidadMaxima = CapacidadMaxima;
    }
}

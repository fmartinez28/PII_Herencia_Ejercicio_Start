namespace Library;
using System;
public abstract class Conductor:Usuario{
    public string Biography;
    public string ModeloVehiculo;
    public Vehiculo vehiculo;

    public abstract int GetMaxCapacity();
}


public class ConductorPool:Conductor{

    public int MaxCapacity;
    public ConductorPool(string Nombre, string Apellido, string Cedula, Vehiculo Micro)
    {
        this.Nombre = Nombre;
        this.Apellido = Apellido;
        this.Cedula = Cedula;
        this.vehiculo = Micro;
    }
    public override int GetMaxCapacity(){
        if (!(vehiculo is null)){
            return vehiculo.CapacidadMaxima;
        }
        throw new Exception("El vehículo no está asignado.");
    }

    public override Rating GetCalificacion()
    {
        return Calificacion;
    }

    public override void Calificar(Rating qualification)
    {
        Calificacion = qualification;
    }
}

public class ConductorComun:Conductor{
    public ConductorComun(string Nombre, string Apellido, string Cedula, Vehiculo Auto)
    {
        this.Nombre = Nombre;
        this.Apellido = Apellido;
        this.Cedula = Cedula;
        this.vehiculo = Auto;
    }
    public override int GetMaxCapacity()
    {
        return 1;
    }
    public override Rating GetCalificacion()
    {
        return Calificacion;
    }

    public override void Calificar(Rating qualification)
    {
        Calificacion = qualification;
    }
}


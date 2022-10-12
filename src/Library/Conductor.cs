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
    public override int GetMaxCapacity(){
        if (!(vehiculo is null)){
            return vehiculo.CapacidadMaxima;
        }
        throw new Exception("El vehículo no está asignado.");
    }

    public override string GetCalificacion()
    {
        return $"{Calificacion}";
    }

    public override void Calificar(Rating qualification)
    {
        Calificacion = qualification;
    }
}
public class ConductorComun:Conductor{
    public override int GetMaxCapacity()
    {
        return 1;
    }
    public override string GetCalificacion()
    {
        return $"{Calificacion}";
    }

    public override void Calificar(Rating qualification)
    {
        Calificacion = qualification;
    }
}
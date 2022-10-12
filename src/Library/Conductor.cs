namespace Library;
using System;
public abstract class Conductor:Usuario{
    public string Biography;
    public Vehiculo vehiculo;

    public abstract int GetMaxCapacity();
}

public abstract class ConductorPool:Conductor{
    public string ModeloVehiculo;
    public int MaxCapacity;
    public int GetMaxCapacity(){
        if (!(vehiculo is null)){
            return vehiculo.Capacity;
        }
        throw new Exception("El vehículo no está asignado.");
    }
}
public abstract class ConductorComun:Conductor{
    public string ModeloVehiculo;
}

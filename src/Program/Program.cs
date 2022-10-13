using System;
using System.Collections.Generic;
using Library;
namespace PII_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Conductor> Conductores = new List<Conductor>();
            List<Pasajero> Pasajeros = new List<Pasajero>();
            
            // En éste método deberas mostrar un ejemplo de funcionamiento de tu programa an pseudocódigo. A continuación te 
            // planteamos un ejemplo de como hacerlo. Esto no significa que te limites a hacer solamente esto, debes pensar 
            // en grande!

            Usuario User1 = new Pasajero();
            User1.Nombre="Ruperto";
            User1.Apellido="Ramirez";
            User1.Cedula="54678919";

            Usuario User2 = new Pasajero();
            User2.Nombre="Lorelei";
            User2.Apellido="Liju";
            User2.Cedula="57538919";

            TwitterPrinter.PrintRegistro(User1, imagen);
            TwitterPrinter.PrintRegistro(User2, imagen);










            // Usuario pasajero2 = nuevo Pasajero()
            // Usuario pasajero3 = nuevo Pasajero()
            // Usuario conductor1 = nuevo Conductor()
            // Usuario conductorPool1 = nuevo ConductorPool(maxPasajeros = 3)
            // UcuRideShare rideShare = nuevo UcuRideShare()
            
            // rideShare.Add(conductor1)
            // Se publica en Twitter un nuevo conductor!

            // rideShare.Add(conductorPool1)
            // Se publica en Twitter un nuevo conductor!
            
            // rideShare.Add(pasajero1)
            // Se publica en Twitter nuevo registro de pasajero!
            
            // rideShare.Add(pasajero2)
            // Se publica en Twitter nuevo registro de pasajero!

            // rideShare.Add(pasajero3)
            // Se publica en Twitter nuevo registro de pasajero!

            
        }
    }
}

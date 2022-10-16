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


            Vehiculo V1 = new Vehiculo("Renault", "Deportivo", 2015, "Negro", "7475", 7);
            Vehiculo V2 = new Vehiculo("Toyota", "Sub", 2001, "Blanco", "3333", 5);
            Vehiculo V3 = new Vehiculo("Geely", "Pickup", 2022, "Gris", "1618", 2);
            Vehiculo V4 = new Vehiculo("Ferrari", "Descapotable", 2021, "Rojo", "1111", 2);



            Usuario User1 = new Pasajero("Ruperto", "Ramirez","54678919");
            
            Usuario User2 = new Pasajero("Lorelei","Liju","57538919");

            Usuario User3 = new ConductorPool("Gaston","Perez","35242864",V1);

            Usuario User4 = new ConductorPool("Felipe","Marquez","35215642",V2);

            Usuario User5 = new ConductorComun("Luis","Suarez","36871231",V4);

            Usuario User6 = new ConductorPool("Santiago","Santi","33241563",V3);

            Usuario ElMejorConductor = new ConductorPool("Mike","Hawk","3877876",V2);
           
            TwitterPrinter.PrintRegistro(User1, "..\\Imagenes\\3.png");
            TwitterPrinter.PrintRegistro(User2, "..\\Imagenes\\1.jpeg");
            TwitterPrinter.PrintRegistro(User3, "..\\Imagenes\\4.jpg");
            TwitterPrinter.PrintRegistro(User4, "..\\Imagenes\\5.jpg");
            TwitterPrinter.PrintRegistro(User5, "..\\Imagenes\\2.webp");
            TwitterPrinter.PrintRegistro(User6, "..\\Imagenes\\6.webp");
            TwitterPrinter.PrintRegistro(ElMejorConductor, "..\\Imagenes\\ElMejorConductor.webp");










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

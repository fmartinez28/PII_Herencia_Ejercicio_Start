using System;
using TwitterUCU;

namespace Library;

public static class TwitterPrinter
{
    public static void PrintRegistro(Usuario user, string imagen)
    {
        var twitter = new TwitterImage();
        string tipo = (user is Pasajero) ? "pasajero" : "conductor";
        string texto = $"¡Nuevo {tipo}! Bienvenido, {user.Nombre} {user.Apellido}";
        Console.WriteLine(twitter.PublishToTwitter(texto,@imagen));
    }
}
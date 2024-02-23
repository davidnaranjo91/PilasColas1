using PilasColas.Logic;
using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {
        var pilas = new Pilas(5);
        pilas.Entrada(1);
        pilas.Entrada(2);
        pilas.Entrada(3);
        pilas.Entrada(10);
        Console.WriteLine("El ultimo en Salir es:");
        Console.WriteLine(pilas.Salida());


      
        var colas = new Colas(5);
        colas.Entrar(1);
        colas.Entrar(2);
        colas.Entrar(3);
        colas.Entrar(10);
        Console.WriteLine("El primero en Salir es:");
        Console.WriteLine(colas.Salir());


    }

}
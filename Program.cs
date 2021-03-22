using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.Clear();
         
        string numeroEntrada;
        double medida;
        double centimetros;
        double quilometros;

        Console.WriteLine("coloque uma medida em metros e veja seus equivalentes em quilômetros e centímetros");
        Console.WriteLine();
        
        Console.Write("Entre com a medida:");
        numeroEntrada = Console.ReadLine();

        medida = Convert.ToDouble(numeroEntrada);

        centimetros = medida * 100 ;

        quilometros = medida / 1000 ;

        Console.WriteLine();

        Console.WriteLine("--- Equivalência ---");
        Console.WriteLine();

        Console.WriteLine($"{centimetros} cm"); 
        Console.WriteLine($"{medida} m");
        Console.WriteLine($"{quilometros:n2} km");

        
        }
    }
}

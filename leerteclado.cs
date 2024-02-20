using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leer_teclado
    internal class Program
{


    public static void Main(string[] args)
    {
        Console.WriteLine("La sumatoria de dos numeros");
        Console.Write("Ingresa un numero: ");
        string dato = Console.ReadLine();

        int n1 = int.Parse(dato);

        Console.Write("Ingresa otro número: ");
        dato = Console.ReadLine();
        int n2 = int.Parse(dato);
        int suma = n1 + n2;
        Console.WriteLine("El resultado de los dos números es: {0}", suma);
        Console.ReadLine();


    }
}
}

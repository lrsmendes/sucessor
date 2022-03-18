using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nome
{
    class Program
    {
        static void Main(string[] args)
        {   // Por L.R. Mendes, (c) 2022
            Console.WriteLine("(c)Raziel, 2022\n");
            double a, b, c;
            Console.Write("Escreva um valor: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = a + 1;
            c = a - 1;
            
            Console.WriteLine("\nO seu antecessor é o número " + c + ".");
            Console.WriteLine("\nEnquanto o seu sucessor é o número " + b + ".");

            Console.Write("\nAperte uma tecla para sair...");
            Console.ReadKey();
        }
    }
}

using Miniräknare.Models;
using System;
using System.Diagnostics;

namespace Miniräknare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till vår fantastiska miniräknare");

            Console.Write("Ange variabel a: ");
            string variabelA = Console.ReadLine();

            Console.Write("Ange variabel b: ");
            string variabelB = Console.ReadLine();

            Console.Write("Ange variabel c: ");
            string variabelC = Console.ReadLine();

            int   a = int.Parse(variabelA)
                , b = int.Parse(variabelB)
                , c = int.Parse(variabelC);

            int result = Calculator.Add(a, b, c);

            Console.WriteLine("Resultatet är: " + result);
        }
    }
}

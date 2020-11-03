using Miniräknare.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Miniräknare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till vår fantastiska miniräknare");

            Console.Write("Hur många tal vill du plussa ihop? ");
            string numberOfIntegers = Console.ReadLine();

            int integers = int.Parse(numberOfIntegers);


            //Calculator calculator = new Calculator();
            //List<int> myList = new List<int>();

            //for (int i = 1; i <= integers; i++)
            //{
            //    Console.Write("Ange tal #" + i + ": ");
            //    string talString = Console.ReadLine();
            //    int tal = int.Parse(talString);
            //    myList.Add(tal);
            //}

            //calculator.Add(myList);



            Calculator calculator = new Calculator();
            
            for (int i = 1; i <= integers; i++)
            {
                Console.Write("Ange tal #" + i + ": ");
                string talString = Console.ReadLine();
                int tal = int.Parse(talString);
                calculator.Add(tal);

                Console.WriteLine("[Nya resultatet är: " + calculator.Result + "]");
            }

            Console.WriteLine("Resultatet är: " + calculator.Result);


            //Console.Write("Ange variabel a: ");
            //string variabelA = Console.ReadLine();

            //Console.Write("Ange variabel b: ");
            //string variabelB = Console.ReadLine();

            //Console.Write("Ange variabel c: ");
            //string variabelC = Console.ReadLine();

            //int   a = int.Parse(variabelA)
            //    , b = int.Parse(variabelB)
            //    , c = int.Parse(variabelC);

            //Calculator calculator = new Calculator();
            //calculator.Add(a, b, c);

            //Console.WriteLine("Resultatet är: " + calculator.Result);
        }
    }
}

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

            //try
            //{

            //}
            //catch
            //{

            //}

            int a = 0, b = 0, c = 0, result;

            
            if (!int.TryParse(variabelA, out a))
            {
                Console.WriteLine("Variabel A gick inte att konvertera till int, då denna är av fel format");
            }




            //try
            //{
            //    a = int.Parse(variabelA);
            //}
            //catch (FormatException fex)
            //{
            //    Console.WriteLine("Det du angav i variabel A, var ingen integer");
            //}
            //catch (OverflowException oex)
            //{
            //    Console.WriteLine("A du angav är alldeles för stor");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Någonting gick fel!");
            //}

            //try
            //{
            //    b = int.Parse(variabelB);
            //}
            //catch (FormatException fex)
            //{
            //    Console.WriteLine("Det du angav i variabel B, var ingen integer");
            //}
            //catch (OverflowException oex)
            //{
            //    Console.WriteLine("B du angav är alldeles för stor");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Någonting gick fel!");
            //}

            //try
            //{
            //    c = int.Parse(variabelC);
            //}
            //catch (FormatException fex)
            //{
            //    Console.WriteLine("Det du angav i variabel C, var ingen integer");
            //}
            //catch (OverflowException oex)
            //{
            //    Console.WriteLine("C du angav är alldeles för stor");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Någonting gick fel!");
            //}


            //result = a + b + c;
            //Console.WriteLine("Resultatet är " + result);

        }
    }
}

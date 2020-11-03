using System;
using System.Collections.Generic;
using System.Text;

namespace Miniräknare
{
    public class Calculator
    {
        public int Result { get; set; }

        public Calculator()
        {
            Result = 0;
        }

        public void Add(int a)
        {
            Result += a;
        }

        public void Add(List<int> numbers)
        {
            for (var i=0; i < numbers.Count; i++)
            {
                Result += numbers[i];
            }
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public static int Add(int a, int b, int c, int d)
        {
            return a + b + c;
        }

        public static int Add(int a, int b, int c, int d, int e)
        {
            return a + b + c;
        }
    }
}

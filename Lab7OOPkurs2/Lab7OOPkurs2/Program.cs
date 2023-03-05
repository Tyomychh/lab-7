using System;

namespace Lab7OOPkurs2
{
    internal class LyambdaOperators
    {
        public delegate int arithmetic(int x, int y);

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int p = int.Parse(Console.ReadLine());
            arithmetic arithmetic = (x, y) => x + y;
            Console.WriteLine(arithmetic(t, p) + "  result of addition");
            arithmetic += (x, y) => x - y;
            Console.WriteLine(arithmetic(t, p) + "  subtraction result");
            arithmetic += (x, y) => x * y;
            Console.WriteLine(arithmetic(t, p) + "  result of multiplication");
            arithmetic += (x, y) =>
            {
               int g = 0;
               try
               {
                  g = x / y;
               }
               catch(DivideByZeroException e)
               {
                  Console.WriteLine(e.Message);
               }
               return g;
            };
            Console.WriteLine(arithmetic(t, p) + "  result of division");
        }
    }
}

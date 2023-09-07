using System;

namespace lab3ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            

            Console.WriteLine(factorial(n));
        }

        static int factorial(int x)
        {

            int factorial = 1;

            for (int i = 1; i <= x; i++)
            {
                factorial = factorial * i;
            }

            return factorial;

        }
    }
}

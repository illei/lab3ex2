using System;

namespace lab3ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            /*Scrieti o functie care va determina daca un numar este sau nu numar prim. Apelati-o si afisati-i rezultatul*/

            Console.WriteLine(isPrim(n));
        }

        static bool isPrim(int x)
        {
            int a = 0;
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0) a++;
                
            }

            if (a == 2)
            {
                return true;

            }
            else return false;

        }
    }
}

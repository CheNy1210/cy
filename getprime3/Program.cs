using System;

namespace getprime3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2-100的所有素数为：");
            int i = 2;
            for (i = 2; i <= 100; i++)
            {
                if (IsPrimeNumber(i))
                    Console.Write(i+",");
            }
        }
        public static bool IsPrimeNumber(int n)
        {
            int i;
            bool c = true;
            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                    c = false;
            }
            return c;
        }
    }
}

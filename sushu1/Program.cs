using System;

namespace sushu1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            int a = 0;
            int[] c = new int[7];
            Console.Write("请输入一个100以内的整数：");
            s = Console.ReadLine();
            a = Int32.Parse(s);
            GetPrime(a,out c);
            Console.Write("它的所有素数因子为：");
            foreach (int j in c)
            {
                Console.Write(j + ",");
            }
        }
        public static bool IsPrimeNumber(int n)
        {
            int i;
            bool c=true;
            for(i=2;i<n; i++)
            {
                if (n % i == 0)
                    c = false;              
            }
            return c;
        }
        public static void GetPrime(int a,out int[] b)
        {
            b = new int[7];
            int i,j = 0;
            if (!IsPrimeNumber(a))
            {
                for (i = 2; i <= a; i++)
                {
                    while (a % i == 0 && IsPrimeNumber(i))
                    {
                        b[j] = i;                       
                        j++;
                        a = a / i;
                    }
                }

            }
            else b[j] = a;           

        }
    }
}

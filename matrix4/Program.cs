using System;

namespace matrix4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = new int[,] { { 1, 2, 3, 4, 5 }, { 0, 1, 2, 3, 4 }, { 9, 0, 1, 2, 3 }, { 8, 9,0, 1, 2 } };            
            Console.WriteLine("一个矩阵为:");
            Console.WriteLine("1,2,3,4,5");
            Console.WriteLine("0,1,2,3,4");
            Console.WriteLine("9,0,1,2,3");
            Console.WriteLine("8,9,0,1,2");
            Console.WriteLine("该矩阵是否为托普利茨矩阵:"+ IsToeplitzMatrix(a));

        }
        public static bool IsToeplitzMatrix(int[,] a)
        {
            bool c = true;
            int i, j = 0;
            for (i = 0; i < a.GetLength(0) - 1; i++)
            {
                for (j = 0; j < a.GetLength(1) - 1; j++)
                {
                    if (a[i + 1, j + 1] != a[i, j])
                        c = false;
                }
            }
            return c;
        }
    }
}

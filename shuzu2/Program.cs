using System;

namespace shuzu2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[7] { 4, 2, 6, 3, 7, 1, 5 };
            Console.WriteLine("有一个数组为{4, 2, 6, 3, 7, 1, 5 }");
            count(a, out double min, out double max, out double sum, out double average);
            Console.WriteLine("最小值：" + min);
            Console.WriteLine("最大值：" + max);
            Console.WriteLine("各项和：" + sum);
            Console.WriteLine("平均值：" + average);
        }
        public static void count(int []a,out double min, out double max, out double sum, out double average)
        {
            min = a[0];
            max = a[0];
            sum = a[0];
            average = 0;
            int i = 0;
            for (i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                    max = a[i];
                else if (a[i]<min) 
                    min = a[i];
                sum += a[i];
            }
            average = sum / a.Length;
        }
    }
}

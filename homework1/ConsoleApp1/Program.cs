using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            double a = 0;
            double b = 0;
            Console.Write("Please input a double number:");
            s = Console.ReadLine();
            a = Double.Parse(s);
            Console.Write("Please input another double number:");
            s = Console.ReadLine();
            b = Double.Parse(s);
            Console.Write("Please input a operator:");
            s = Console.ReadLine();
            switch(s)
            {
                case "+":
                    Console.WriteLine($"a+b:{a + b}");
                    break;
                case "-":
                    Console.WriteLine($"a-b:{a - b}");
                    break;
                case "*":
                    Console.WriteLine($"a*b:{a * b}");
                    break;
                case "/":
                    Console.WriteLine($"a/b:{a / b}");
                    break;
            }
            
        }
    }
}

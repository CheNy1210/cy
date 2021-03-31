using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Shape1
{
    public class Shape
    {
        public double GetArea;
        public bool IsLegal;
        public string Info;


    }
    class Square:Shape
    {
        public int side;
        public Square(int a)
        {
            side = a;
        }
        public new string Info => $"正方形:side={side}.";
        public new double GetArea(int side)
        {
            if (!IsLegal(side))
                return 0;
            else
                return side * side;
        }
        public new static bool IsLegal(int side)
        {
            bool c = true;
            if (side <= 0)
                c = false;
            return c;
        }
    }
    class Rectangle:Shape
    {
        public int side0;
        public int side1;
        public Rectangle(int a,int b)
        {
            side0 = a;
            side1 = b;
        }
        public new string Info => $"矩形:length={side0},width={side1}.";
        public new double GetArea(int side0, int side1)
        {
            if (!IsLegal(side0, side1))
                return 0;
            else
                return side0 * side1;
        }
        public new static bool IsLegal(int side0, int side1)
        {
            bool c = true;
            if (side0 <= 0 || side1 <= 0)
                c = false;
            return c;
        }
    }
    class Triangle:Shape
    {
        public int side0;
        public int side1;
        public int side2;
        public Triangle(int a,int b,int c)
        {
            side0 = a;
            side1 = b;
            side2 = c;
        }
        public new string Info => $"三角形:a={side0},b={side1},c={side2}.";
        public new double GetArea(int side)
        {

            if (!IsLegal(side0, side1, side2))
            {
                return 0;
            }
            double p = (side0 + side1 + side2) / 2;
            double m = Math.Sqrt(p * (p - side0) * (p - side1) * (p - side2));
            return m;
        }
        public new static bool IsLegal(int side0, int side1, int side2)
        {
            bool c = true;
            if (side0 <= 0 || side1 <= 0 || side2 <= 0 || side0 + side1 <= side2 || side0 + side2 <= side1)
                c = false;
            return c;
        }
    }
    public class Factory
    {
        public static Shape CreateShape(string type, params int[] side)
        {
            Shape shape = null;
            switch (type)
            {
                case "Rectangle":
                    shape = new Rectangle(side[0],side[1]);
                    break;
                case "Square":
                    shape = new Square(side[0]);
                    break;
                case "Triangle":
                    shape = new Triangle(side[0],side[1],side[2]);
                    break;
            }
            return shape;
        }
        static Random random = new Random();
        public static Shape CreateRandomShape()
        {
            int type = random.Next(0, 4);
            Shape shape = null;
            while (shape == null)
            {
                switch (type)
                {
                    case 0:
                        shape = CreateShape("squre", random.Next(200));
                        break;
                    case 1:
                        shape = CreateShape("circle", random.Next(200));
                        break;
                    case 2:
                        shape = CreateShape("rectangle", random.Next(200), random.Next(200));
                        break;
                    case 3:
                        shape = CreateShape("triangle", random.Next(200), random.Next(200), random.Next(200));
                        break;
                }
            }
            return shape;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {           
                List<Shape> shape = new List<Shape>();
                for (int i = 0; i < 10; i++)
                {
                    shape.Add(Factory.CreateRandomShape());
                }
                shape.ForEach(a=>
                          Console.WriteLine($"{a.Info}, area={a.GetArea}"));
        }
    }
}
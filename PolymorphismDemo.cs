using System;

namespace PolymorphismDemo
{
    class Area
    {
        public void area(int s)
        {
            Console.WriteLine("Area of Square is " + s * s);
        }
        public void area(int l,int b)
        {
            Console.WriteLine("Area of Rectangle is " + l * b);
        }
        public void area(float f,int b,int h)
        {
            Console.WriteLine("Area of Triangle is " + f * b * h);
        }
        public void area(float f,int r)
        {
            Console.WriteLine("Area of Circle is " + f * r * r);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Area a = new Area();
            a.area(5, 3);
            a.area(0.5f, 10);
            a.area(6);
            a.area(0.5f, 8, 5);
            Console.ReadKey();


        }
    }
}

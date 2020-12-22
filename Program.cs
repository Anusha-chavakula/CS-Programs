using System;

namespace Inheritance
{
    class Shape
    {
        protected int width, height;
        public void area()
        {

        }
        public void display()
        {
            Console.WriteLine("In Shape class");
        }
    }
    class Rectangle:Shape
    {
 
       public  Rectangle(int l,int b)
        {
            width = l;
            height = b;
        }
        public void area()
        {
            Console.WriteLine("Area of rectangle is "+(width*height));
        }
        public void display()
        {
            Console.WriteLine("In Rectangle class");
        }


    }
    class Triangle : Shape
    {
        public Triangle(int w,int b)
        {
            width = w;
            height = b;
        }
        public void area()
        {
            Console.WriteLine("Area of Triangle is "+(0.5*width * height));
        }
        public void display()
        {
            Console.WriteLine("In Triangle class");
        }
    }
  
    class Program
    {
        static void Main(string[] args)
        {
            int l, b, w, h;
            Console.WriteLine("Enter length and breadth of a rectangle");
            l=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            Rectangle r = new Rectangle(l,b);
            r.display();
            r.area();

            Console.WriteLine("Enter base and height of a triangle");
            w = Convert.ToInt32(Console.ReadLine());
            h = Convert.ToInt32(Console.ReadLine());
            Triangle t = new Triangle(w, h);
            t.display();
            t.area();
        }
    }
}

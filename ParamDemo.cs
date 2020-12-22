using System;

namespace ParamDemo
{
    class Program
    {
        public const float pi = 3.14f;
        public readonly int radius;
        public Program()
        {
            radius = 10;
        }
        public void area()
        {
            Console.WriteLine("Area of triangle is " + pi * radius * radius);
        }
        public void Param1(int a,params int[] array)
        {
            Console.WriteLine("In Param1 method");
            Console.WriteLine(a);
            for(int i=0;i<array.Length;i++)
            {
                Console.WriteLine(array[i]);
            }

        }
        public void Param2(int a,float b,object[] array)
        {
            Console.WriteLine("In Param2 method");
            Console.WriteLine(a + "\n" + b);
            for(int i=0;i<array.Length;i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] a = { 14, 27, 61, 10 };
            p.Param1(17, a);
            p.Param1(12);
            object[] b = { 95, "Hi", "Hello", "List" };
            p.Param2(12,5.4f,b);
            p.area();
        }
    }
}

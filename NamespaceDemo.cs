using System;
namespace Namespace
{
    class Program
    {
        public void Pattern()
        {
            Console.WriteLine("In  First Namepace");
            for(int i=0;i<10;i++)
            {
                for(int j=0;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

    }
}

namespace NamespacesDemo
{
    class Program
    {
        public void Pattern()
        {
            Console.WriteLine("In Second Namespace");
            for(int i=10;i>=0;i--)
            {
                for(int j=0;j<i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Namespace.Program p = new Namespace.Program();
            NamespacesDemo.Program p1 = new NamespacesDemo.Program();
            p.Pattern();
            p1.Pattern();
        }
    }
}

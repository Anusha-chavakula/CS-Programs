using System;
using System.Reflection;

namespace ReflectionDemo
{
    class Demo
    {
        int a, b,x;
        public Demo()
        {
            a = 10;
            b = 5;
        }
        public Demo(int x,int y)
        {
            a = x;
            b = y;
        }
        public void area()
        {
            x = a * b;
        }
        public void display()
        {
            Console.WriteLine("Area is " + x);
        }
    }
    class ReflectionDemo
    {
        static void Main(string[] args)
        {
            Type type = typeof(Demo);
            Console.WriteLine("Class name: " + type.Name);
            MethodInfo[] methodInfo = type.GetMethods();
            foreach(var method in methodInfo)
            {
                Console.WriteLine("---Method name: " + method.Name+" Return Type: "+method.ReturnType);
                ParameterInfo[] p = method.GetParameters();
                foreach(var a in p)
                {
                    Console.WriteLine("----Parameter: " + a.Name + "Type: " + a.ParameterType);
                }

            }
            ConstructorInfo[] infos = type.GetConstructors();
            foreach(var i in infos)
            {
                Console.WriteLine("----Constructor name: " + type.Name);
            }
        }
    }
}

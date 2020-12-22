using System;

public delegate void ArithmeticOperation(int x);
namespace DelegateDemo
{
    
    class DelegateDemo
    {
        static int c=64;
        public static void AddNum(int a)
        {
            c = c+ a ;
        }
        public static void SubNum(int a)
        {
            c += a; 
        }
        public static void MultipleNum(int a)
        {
            c *=a;
        }
        public static void DivNum(int a)
        {
            c /=a;
        }
        public static  int getNum()
        {
            return c;
        }


        static void Main(string[] args)
        {
            ArithmeticOperation a = new ArithmeticOperation(AddNum);
            ArithmeticOperation b = new ArithmeticOperation(MultipleNum);
            ArithmeticOperation c = new ArithmeticOperation(DivNum);
            ArithmeticOperation d = new ArithmeticOperation(SubNum);
            a(261);
            Console.WriteLine("Addition : " + getNum());
            c(32);
            Console.WriteLine("Division : " + getNum());
            b(10);
            Console.WriteLine("Multiplication : " + getNum());
            d(54);
            Console.WriteLine("Subtraction : " + getNum());
        }
    }
}

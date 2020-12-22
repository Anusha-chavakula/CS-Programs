using System;
using System.Threading;

namespace MultiThreadingDemo
{
    class ThreadDemo
    {
        public void Thread1()
        {
            Console.WriteLine("In thread 1 method");
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("In thread 1,i= " + (i + 1));
               
            }
            Thread.Sleep(1000);

            Console.WriteLine("End of thread1");
        }
        public void Thread2()
        {
            Console.WriteLine("In thread 2 method");
         
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("In thread 2,i= " + (i + 1));
                
            }
            Console.WriteLine("End of thread2");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            ThreadDemo t = new ThreadDemo();
            ThreadStart thread1 = new ThreadStart(t.Thread1);
            ThreadStart thread2 = new ThreadStart(t.Thread2);
            Console.WriteLine("In Main thread");
            Thread child1 = new Thread(thread1);
            Thread child2 = new Thread(thread2);
            child1.Start();
            
            child2.Start();
            Console.WriteLine("Current thread is " + Thread.CurrentThread);
            Console.WriteLine("End of Main");

        }
    }
}

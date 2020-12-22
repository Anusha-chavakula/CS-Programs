using System;

namespace ExceptionHandlingDemo
{
    class ExceptionHadlingDemo
    {
        public void GetArray(int[] a, int n)
        {
            try
            {
                Console.WriteLine("Before exception");
                Console.WriteLine("Enter values ");
                for (int i = 0; i < n; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());

                }
                //Console.WriteLine("The numbers are\n");
                //for (int i = 0; i < n; i++)
                //{
                //    Console.WriteLine(a[i]);
                //}
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("In finally block");
               
            }
        }

        static void Main(string[] args)
        {
            ExceptionHadlingDemo ed = new ExceptionHadlingDemo();
            int[] a = new int[5];
            ed.GetArray(a, 5);
          
        }
    }
}

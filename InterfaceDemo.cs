using System;

namespace InterfaceDemo
{
    interface Withdraw
    {
       public  void withdraw(int a);
    }
    interface Deposit
    {
        public void deposit(int a);
    }
    class InterfaceDemo : Withdraw, Deposit
    {
        int amount;
        InterfaceDemo()
        {
            amount = 500;
        }
        public void withdraw(int a)
        {
            if(amount<a)
            {
                Console.WriteLine("Insufficient amount");
            }
            else
            {
                amount = amount - a;
                Console.WriteLine("Balance amount is " + amount);
            }
        }
        public void deposit(int a)
        {
            amount = amount+a;
            Console.WriteLine("Balance amount is " + amount);
        }

        static void Main(string[] args)
        {
            int amount1, amount2;
            Console.WriteLine("Enter amount to deposit");
            amount1 = Convert.ToInt32(Console.ReadLine());
            InterfaceDemo i = new InterfaceDemo();
            i.deposit(amount1);
            Console.WriteLine("Enter amount to withdraw");
            amount2 = Convert.ToInt32(Console.ReadLine());
            i.withdraw(amount2);
            Console.WriteLine("Enter amount to deposit");
            amount1 = Convert.ToInt32(Console.ReadLine());
            i.deposit(amount1);

        }
    }
}

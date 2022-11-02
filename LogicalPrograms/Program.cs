using System;
namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args) //Entry point of our application
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.FibonacciSeries" + "\n" + "2.PerfectNumber" + "\n" + "3.Exit");
                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                   case 1:
                      FibonacciSeries print = new FibonacciSeries();
                      print.Series(10);
                   break;
                   case 2:
                       PerfectNumber check = new PerfectNumber();
                        check.Check(28);
                        break;
                   case 3:
                        flag= false;
                        break;
            }  
            }
        }
    }
}

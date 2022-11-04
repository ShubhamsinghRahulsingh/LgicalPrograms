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
                Console.WriteLine("\n"+"1.FibonacciSeries"+"\n"+"2.PerfectNumber"+"\n"+"3.PrimeNumber"+"\n"+"4.ReverseNumber"+"\n"+"5.CouponNumber"+"\n"+"6.Exit");
                Console.Write("Enter your choice: ");
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
                        PrimeNumber prime = new PrimeNumber();
                        prime.CheckPrime(17);
                        break;
                    case 4:
                        ReverseNumber find = new ReverseNumber();
                        find.Reverse(359);
                        break;
                    case 5:
                        CouponNumber.GenerateCoupons(10);
                        break;
                    case 6:
                        flag= false;
                        break;
            }  
            }
        }
    }
}

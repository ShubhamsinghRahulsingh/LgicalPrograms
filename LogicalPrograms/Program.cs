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
                Console.WriteLine("\n"+"1.FibonacciSeries"+"\n"+"2.PerfectNumber"+"\n"+"3.PrimeNumber"+"\n"+"4.ReverseNumber"+"\n"+"5.CouponNumber"+"\n"+"6.TemperatureConversion"+"\n"+"7.MonthlyPayment"+"\n"+"8.DayOfWeek"+"\n"+"9.StopWatch"+"\n"+"10.exit");
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
                        TempConversion.TemperatureConversion(100);
                        break;
                    case 7:
                        MonthlyPaymentLoan.MonthlyPayment(100000, 10, 5);
                            break;
                    case 8:
                        WeekDay.DayOfWeek();
                        break;
                    case 9:
                        StopWatch time = new StopWatch();
                        time.Start();
                        break;
                    case 10:
                        flag= false;
                        break;
            }  
            }
        }
    }
}

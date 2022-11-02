using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args) //Entry point of our application
        {
            FibonacciSeries print = new FibonacciSeries();
            print.Series(10);
        }
    }
}

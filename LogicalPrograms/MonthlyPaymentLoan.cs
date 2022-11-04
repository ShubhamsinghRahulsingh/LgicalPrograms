using System;
namespace LogicalPrograms
{
    public class MonthlyPaymentLoan
    {
        public static void MonthlyPayment(int P, int R, int Y)
        {
            float r = (float)R / (12 * 100);
            int n = 12 * Y;
            double payment =( P * r) /( 1 - (Math.Pow((1 + r), -n)));
            Console.WriteLine("Monthly payment you have to make for "+Y +" years is " +payment);

        }
    }
}
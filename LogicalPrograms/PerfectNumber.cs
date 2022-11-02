using System;
namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public void Check(int num)
        {
            int sum = 0;
            for (int i = 1; i <=num/2 ; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            if(num==sum)
                Console.WriteLine("Number we have is a perfect Number");
            else
                Console.WriteLine("Number we have is not a perfect Number");
        }

    }
}

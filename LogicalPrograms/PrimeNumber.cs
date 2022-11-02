using System;
namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public void CheckPrime(int num)
        {
            int count = 0;
            for(int i = 1; i <= num; i++)
            {
                if(num % i == 0)
                    count++;
            }
            if(count == 2)
                Console.WriteLine("Given Number is a prime Number");
            else
                Console.WriteLine("Given Number is not a prime Number");
        }

    }
}

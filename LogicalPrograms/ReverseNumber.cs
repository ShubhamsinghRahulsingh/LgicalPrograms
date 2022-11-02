using System;
namespace LogicalPrograms
{
    public class ReverseNumber
    {
        public void Reverse(int num)
        {
            int reverse = 0;
            int actual = num;
            while(num>0)
            {
                int remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num /= 10; 
            }
            Console.WriteLine("Reverse of a number {0} is {1}",actual,reverse);
        }
    }
}

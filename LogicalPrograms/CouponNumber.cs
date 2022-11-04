using System;
namespace LogicalPrograms
{
    public class CouponNumber
    {
        static int Count=0;
        public static int GenerateRandom()
        {
            Random random = new Random();
            int randomNum=random.Next(1,11);
            Count++;
            return randomNum;
        }
        public static void GenerateCoupons(int num)
        {
            int[] coupons = new int[num];
            for(int i = 0; i < coupons.Length; i++)
            {
                int number= 0;
                int random=GenerateRandom();
                for(int j=0; j <= i; j++)
                {
                    if(coupons[j] == random)
                    {
                        number++;
                    }
                }
                if (number == 0)
                {
                    coupons[i] = random;
                }
                else
                {
                    i -= 1;
                }
            }
            foreach(int data in coupons)
            {
                    Console.WriteLine(data);
            }
            Console.WriteLine("{0} random numbers are needed to have 10 distinct coupon numbers:", Count);

        }
    }
}

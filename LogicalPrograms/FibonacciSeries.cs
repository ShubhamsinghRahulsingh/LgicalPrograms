﻿using System;
namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        public void Series(int num)
        {
            int firstNum = 0, secondNum = 1, thirdNum = 0;
            Console.WriteLine(firstNum+"\n"+secondNum);
            for(int i=0; i<num; i++)
            {
                thirdNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = thirdNum;
                Console.WriteLine(thirdNum);
            }
        }
    }
}

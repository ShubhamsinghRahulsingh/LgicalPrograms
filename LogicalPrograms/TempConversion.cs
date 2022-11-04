using System;
namespace LogicalPrograms
{
    public class TempConversion
    {
        public static void TemperatureConversion(int temp)
        {
            Console.WriteLine("Select 1-Celsius to Fahrenheit , 2-Fahrenheit to Celsius");
            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                   float fahr = (temp * (9 / 5f)) + 32;
                   Console.WriteLine("{0}C into fahrenheit is {1}F", temp, fahr);
                    break;
               case 2:
                   float cels = (temp - 32) * (5 / 9f);
                   Console.WriteLine("{0}F into Celsius is {1}C", temp, cels);
                    break;
            }
        }
    }
}

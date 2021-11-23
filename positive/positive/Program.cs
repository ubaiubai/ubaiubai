using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positive
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int[] number;

            int[] positiveNumber;
            Console.WriteLine("Enter the total count of numbers which you want to check ");
            num = Convert.ToInt32(Console.ReadLine());
            number = new int[num];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("enter the number please");
                number[i] = Convert.ToInt32(Console.ReadLine());


            }

            positiveNumber = new int[num];
            for (int i = 0; i < num; i++)
            {

                if (number[i] > 0)
                {
                    positiveNumber[i] = number[i];
                    Console.WriteLine("posetive numbers are" + positiveNumber[i]);

                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of employees: ");
            int employees = int.Parse(Console.ReadLine());
            int[] salaryArray = new int[employees];
   
            for (int i = 0; i < employees; i++)
            {
                Console.WriteLine("{0}. salary of employee: ", i + 1);
                salaryArray[i] = int.Parse(Console.ReadLine());
            }
            Console.ReadKey();
            Console.ReadLine();
        }
    }
}
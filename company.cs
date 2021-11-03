using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace company

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of companies");
            int com_count;
            com_count = Convert.ToInt32(Console.ReadLine());
            company[] com_obj = new company[com_count];

            int count = 0;
            for (int i = 0; i < com_count; i++)
            {
                Console.WriteLine("Enter company {0} details seperated by , : name,sector,location,age ", i + 1);
                string comdetails = Console.ReadLine();
                company c = company.GetCompanyDetails(comdetails);

                if (!com_obj.Contains(c))
                {
                    com_obj[i] = c;
                    count++;

                }
                else if (com_obj.Contains(c))
                {
                    Console.WriteLine("companies1 is same as company2");


                }
                if (count == 2)
                {
                    Console.WriteLine("Bothe companies are different");
                }



            }

            foreach (var item in com_obj)
            {
                Console.WriteLine(item);
            }
        }
    }
}
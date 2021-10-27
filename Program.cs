using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pancard
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] companyempDetails;
            int employeeNo, eAcount;
            Console.WriteLine("how many employee are working in your company");
            employeeNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter account number of your employee");
            eAcount = Convert.ToInt32(Console.ReadLine());

            companyempDetails = new int[employeeNo, eAcount];

            for (int i = 0; i < employeeNo; i++)
            {
                int temp = 0;
                Console.WriteLine("enter customer name");
                string name = Console.ReadLine();

                for (int j = 0; j < eAcount; j++)
                {


                    switch (j)
                    {
                        case 0:
                            Console.WriteLine("enter account 1 detail");
                            break;
                        case 1:
                            Console.WriteLine("enter account 2 detail");
                            break;
                       

                    }

                    temp = temp + Convert.ToInt32(Console.ReadLine());

                }
                Console.WriteLine(name + " total balance :" + temp);
            }
        }
    }
}
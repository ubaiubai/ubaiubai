using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JOB DETAILS
{
    class Program
    {
        static void Main(string[] args)
        {
            Job[] j1;
            int count = int.Parse(Console.ReadLine());
            j1 = new Job[count];
            for (int i = 0; i < count; i++)
            {
                string role;
                string skillset;
                string emptype;
                string location;
                int exp;
                double sal;

                Console.WriteLine("Enter the Role:");
                role = Console.ReadLine();
                Console.WriteLine("Enter the Skillset:");
                skillset = Console.ReadLine();
                Console.WriteLine("Enter the Emptype");
                emptype = Console.ReadLine();
                Console.WriteLine("Enter the Location:");
                location = Console.ReadLine();
                Console.WriteLine("Enter the Minimum Experience");
                exp = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Salary");
                sal = Convert.ToInt64(Console.ReadLine());
                Job j2 = new Job(role, skillset, emptype, location, exp, sal);

            }

            SortbySalary sal1 = new SortbySalary();
            Array.Sort(j1, sal1);
            foreach (var item in j1)

            {
                Console.WriteLine(item.ToString());
            }

            Console.Read();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
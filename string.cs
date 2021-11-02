using System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string2
{
    class Program
    {
        static void Main(string[] args)
        {

            StringBuilder details;
            details = new StringBuilder();
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter age");
            string age = Console.ReadLine();

            Console.WriteLine("Enter address");
            string address = Console.ReadLine();

            Console.WriteLine("Enter contact number");
            string contactnumber = Console.ReadLine();

            Console.WriteLine("Enter qualification");
            string qualification = Console.ReadLine();

            Console.WriteLine("Enter experience");
            string experience = Console.ReadLine();

            Console.WriteLine("name {0} , age {1} , address {2} , contact number {3} , qualification {4} and experience {5} ", name, age, address, contactnumber, qualification, experience);

        }
    }
}
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder details;
            details = new StringBuilder();
            Console.WriteLine("enter your name");
            string username = Console.ReadLine();
            

            Console.WriteLine("enter your age");
             int age =int.Parse(Console.ReadLine());
            

            Console.WriteLine("enter your experience");
            int  experience = int.Parse(Console.ReadLine());
            

            Console.WriteLine("enter your qulification");
            string qualification = Console.ReadLine();
            

            Console.WriteLine("name {0} , age{1}  , exp{3} , qualification{4} ", username, age,  experience, qualification);
            Console.ReadLine();


        }
    }
}

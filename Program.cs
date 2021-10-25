using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int   empid;
            string emailid;
            DateTime DOB;
            int mobienumber;    
            int salalry;
            int exp;

            Console.WriteLine("enter your name");
            name = Console.ReadLine();
            Console.WriteLine("enter your empid");
            empid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your emailid");
            emailid = Console.ReadLine();
            Console.WriteLine("enter your DOB");
            DOB = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("enter your mobilenumber");
            mobienumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your salary");
            salalry = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your exp");
            exp = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("name is "+name+",exp is "+exp+",salary is "+salalry);

        }
    }
}

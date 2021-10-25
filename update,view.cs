using System;

namespace task2
{
    class one
    {
        int salary=0, empid=0, phone=0;
        string name="", email="", dob="", dateofjoin="";
        public void createDetail()
        {
            Console.Write("Enter your empid:");
            empid = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your name:");
            name = Console.ReadLine();
            Console.Write("Enter your dob:");
            dob = Console.ReadLine();
            Console.Write("Enter your email:");
            email = Console.ReadLine();
            Console.Write("Enter your phone:");
            phone = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your dateofjoin:");
            dateofjoin = Console.ReadLine();
            Console.Write("Enter your salary:");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        public void updateDetail()
        {
            Console.Write("Enter your empid:");
            empid = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your name:");
            name = Console.ReadLine();
            Console.Write("Enter your dob:");
            dob = Console.ReadLine();
            Console.Write("Enter your email:");
            email = Console.ReadLine();
            Console.Write("Enter your phone:");
            phone = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your dateofjoin:");
            dateofjoin = Console.ReadLine();
            Console.Write("Enter your salary:");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        public void viewDetail()
        {
            Console.Write("Enter your empid:", empid);

            Console.Write("Enter your name:", name);
            
            Console.Write("Enter your dob:",dob);
           
            Console.Write("Enter your email:",email);
            
            Console.Write("Enter your phone:",phone);
            
            Console.Write("Enter your dateofjoin:",dateofjoin);
            
            Console.Write("Enter your salary:",salary);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.Write("1.create a employee detail\n");
            Console.Write("2.update a employee detail\n");
            Console.Write("3.view employee detail\n");
            Console.Write("Enter your option\n");
           int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                p.createDetail();
            }
            else if (option == 2)
            {
                p.updateDetail();
            }
            else
            {
                p.viewDetail();
                Console.ReadLine();
            }
            
        }
    }
}

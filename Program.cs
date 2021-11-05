﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK2a
{
    class Program
    {
        static void Main(string[] args)
        {
            string email;
            Console.WriteLine("Please Enter your E-mail Id :");
            email = Console.ReadLine();
            Regex regex = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0 - 9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
            RegexOptions.CultureInvariant | RegexOptions.Singleline);
            Console.WriteLine($"The email is {email}");
            bool isValidEmail = regex.IsMatch(email);
            if (!isValidEmail)
            {
                Console.WriteLine($"The email is invalid");

            }
            else
            {
                Console.WriteLine($"The email is valid");
            }

            Console.Read();
        }
    }
}
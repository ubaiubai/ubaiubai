﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facebook
{
	class Program
	{
		static void Main(string[] args)
		{
			int i;
			Facebook[] F1;
			Console.WriteLine("How many Facbook Accounts wants to create:");
			int acc = int.Parse(Console.ReadLine());
			F1 = new Facebook[acc];

			do
			{
				for (i = 0; i < acc; i++)
				{
					F1[i] = new Facebook();
					Console.WriteLine("Enter your First Name :");
					F1[i].Firstname = Console.ReadLine();
					Console.WriteLine("Enter your Last Name :");
					F1[i].Lastname = Console.ReadLine();
					Console.WriteLine("Enter your EmailId :");
					string mail = Console.ReadLine();
					Console.WriteLine("Enter your MobileNo :");
					long numbr = Convert.ToInt64(Console.ReadLine());


					if (i > 0)
					{
						if (F1[0].Emailid.Equals(mail) && F1[0].Mobileno.Equals(numbr))
						{
							Console.WriteLine("mailid or MobileNo already Exist!!");
						}
						else
						{
							F1[i].Emailid = mail;
							F1[i].Mobileno = numbr;
						}

					}
					else
					{
						F1[i].Emailid = mail;
						F1[i].Mobileno = numbr;
					}
				}

			} while (i > 0);

			foreach (var item in F1)
			{
				Console.WriteLine(item.ToString());
			}
			Console.Read();
		}
	}
}
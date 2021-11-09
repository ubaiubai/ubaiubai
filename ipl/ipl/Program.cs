using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ipl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER NUMBER OF TEAMS");
            int no_Of_Teams = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < no_Of_Teams; j++)
            {
                Team t = new Team();
                Console.WriteLine("ENTER TEAM NAME");
                t.TeamName = Console.ReadLine();
                Console.WriteLine("ENTER COUNTRY NAME");
                t.Country = Console.ReadLine();
                Console.WriteLine("ENTER THE NUMBER OF PLAYERS");
                int no_Of_Players = Convert.ToInt32(Console.ReadLine());
                Players[] p_Details = new Players[no_Of_Players];


                for (int i = 0; i < no_Of_Players; i++)
                {
                    Console.WriteLine("ENTER THE ID");
                    int p_Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ENTER THE NAME");
                    string p_Name = Console.ReadLine();
                    Console.WriteLine("ENTER THE age");
                    int p_Age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ENTER THE batting style");
                    string p_BattingStyle = Console.ReadLine();
                    Console.WriteLine("ENTER THE bowling style");
                    string p_BowlingStyle = Console.ReadLine();

                    Players p = new Players(p_Id, p_Name, p_Age, p_BattingStyle, p_BowlingStyle);
                    p_Details[i] = p;


                }

                foreach (var k in p_Details)
                {

                    Console.WriteLine(k);
                }
            }
        }
    }
}
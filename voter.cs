using System;

namespace voter
{
    class Program
    {
        static void Main(string[] args)
        {

            bool ValidateDate(string date)
            {
                try
                {
                    string[] dateParts = date.Split('/');
                    DateTime testDate = new
                        DateTime(Convert.ToInt32(dateParts[2]),
                        Convert.ToInt32(dateParts[0]),
                        Convert.ToInt32(dateParts[1]));
                    return true;
                }
                catch
                {
                    // if a test date cannot be created, the
                    // method will return false
                    return false;
                }

                int vote_age;
                Console.Write("Input the age of the candidate : ");
                vote_age = Convert.ToInt32(Console.ReadLine());
                if (vote_age <= 18)
                {
                    Console.Write("Sorry, You are not eligible to caste your vote.\n");
                    Console.Write("You would be able to caste your vote after {0} year.\n\n", 18 - vote_age);
                }
                else
                    Console.Write("Congratulation! You are eligible for casting your vote.\n\n");
                Console.ReadLine();
            }
        }
    }
}


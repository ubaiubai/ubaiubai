
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmetic
{
    class arithmetic
    { 
        static void Main(string[] args)
        {
            double x;
            double y;
            string operand;
            ConsoleKeyInfo status;
            double answer;

            while (true)
            {
                Console.Write("Enter x: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Y : ");
                y = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please enter an operand (+, -, /, *): ");
                operand = Console.ReadLine();

                switch (operand)
                {
                    case "-":
                        answer = x - y;
                        break;
                    case "+":
                        answer = x + y;
                        break;
                    case "/":
                        answer = x / y;
                        break;
                    case "*":
                        answer = x * y;
                        break;
                    default:
                        answer = 0;
                        break;
                }

                Console.WriteLine(x.ToString() + " " + operand + " " + y.ToString() + " = " + answer.ToString());
                Console.WriteLine("\n\n Do You Want To Break (Y/n)");
                status = Console.ReadKey();
                if (status.Key == ConsoleKey.Y)
                {
                    break;
                }
                Console.WriteLine();
                Console.Clear();
            }
        }

    }
}

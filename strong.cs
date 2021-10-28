using System;

public class strong
{
    static int getFactorial(int number)
    {
        int factorial = 1;
        for (int i = number; i > 1; i--)
        {
            factorial = factorial * i;
        }
        return factorial;
    }

    public static void Main()
    {
        int givenNumber;

        Console.WriteLine("Enter a number to check");
        givenNumber = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        int copyNumber = givenNumber;

        while (copyNumber != 0)
        {
            int lastDigit = copyNumber % 10;
            sum = sum + getFactorial(lastDigit);
            copyNumber = copyNumber / 10;
        }

        if (sum == givenNumber)
        {
            Console.WriteLine("Given number is a strong number");
        }
        else
        {
            Console.WriteLine("Given number is not a strong number");

            Console.ReadLine();
            Console.ReadLine();
        }

    }
}
using System;

class Program
{
    static void Main()
    {
        int number;
        long factorial = 1;  // Use long to handle larger factorials

        // Ask the user to enter a non-negative integer
        Console.Write("Enter a non-negative integer: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");
        }
        else
        {
            int i = 1;
            while (i <= number)
            {
                factorial *= i;
                i++;
            }

            Console.WriteLine($"Factorial of {number} is: {factorial}");
        }

        // Keep the console window open
        Console.ReadLine();
    }
}

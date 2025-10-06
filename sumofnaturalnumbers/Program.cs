
using System;

class Program
{
    static void Main()
    {
        int n, sum = 0;

        // Ask the user to enter a number
        Console.Write("Enter a positive integer: ");
        n = Convert.ToInt32(Console.ReadLine());

        // Calculate the sum from 1 to n using a for loop
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        // Display the result
        Console.WriteLine("Sum of numbers from 1 to " + n + " is: " + sum);

        // Keep the console window open
        Console.ReadLine();
    }
}


using System;

class Program
{
    static void Main()
    {
        // Ask the user to enter a number
        Console.Write("Enter a number: ");

        // Read input from the user and convert it to an integer
        int number = Convert.ToInt32(Console.ReadLine());

        // Check whether the number is even or odd
        if (number % 2 == 0)
        {
            Console.WriteLine(number + " is even.");
        }
        else
        {
            Console.WriteLine(number + " is odd.");
        }

        // Keep the console window open
        Console.ReadLine();
    }
}

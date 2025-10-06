using System;

class Program
{
    static void Main()
    {
        int number;

        // Ask the user to enter a number
        Console.Write("Enter a number to print its multiplication table: ");
        number = Convert.ToInt32(Console.ReadLine());

        // Print the multiplication table up to 10
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }

        // Keep the console window open
        Console.ReadLine();
    }
}

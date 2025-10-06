using System;

class Program
{
    static void Main()
    {
        int marks;

        // Ask the user to enter marks
        Console.Write("Enter marks (0 - 100): ");
        marks = Convert.ToInt32(Console.ReadLine());

        // Check if the marks are within the valid range
        if (marks < 0 || marks > 100)
        {
            Console.WriteLine("Invalid input. Marks should be between 0 and 100.");
        }
        else if (marks >= 85)
        {
            Console.WriteLine("Grade: A");
        }
        else if (marks >= 70)
        {
            Console.WriteLine("Grade: B");
        }
        else if (marks >= 55)
        {
            Console.WriteLine("Grade: C");
        }
        else if (marks >= 40)
        {
            Console.WriteLine("Grade: D");
        }
        else
        {
            Console.WriteLine("Grade: F");
        }

        // Keep the console window open
        Console.ReadLine();
    }
}

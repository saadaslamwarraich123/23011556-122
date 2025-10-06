using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 25, 30, 45, 50, 65, 70, 85, 90, 100 }; // Example array

        Console.Write("Enter a number to search: ");
        int target = Convert.ToInt32(Console.ReadLine());

        bool found = false;

        // Linear search through the array
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == target)
            {
                found = true;
                break;
            }
        }

        if (found)
            Console.WriteLine($"{target} exists in the array.");
        else
            Console.WriteLine($"{target} does not exist in the array.");

        Console.ReadLine();
    }
}


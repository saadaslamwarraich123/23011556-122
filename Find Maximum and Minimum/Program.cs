using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[10];

        // Input 10 integers from the user
        Console.WriteLine("Enter 10 integers:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Initialize max and min with the first element of the array
        int max = numbers[0];
        int min = numbers[0];

        // Find max and min
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        // Print the results
        Console.WriteLine($"Maximum value: {max}");
        Console.WriteLine($"Minimum value: {min}");

        // Keep the console window open
        Console.ReadLine();
    }
}

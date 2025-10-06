using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[10];
        int evenCount = 0, oddCount = 0;

        Console.WriteLine("Enter 10 integers:");

        // Read 10 numbers from the user
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Count even and odd numbers
        foreach (int num in numbers)
        {
            if (num % 2 == 0)
                evenCount++;
            else
                oddCount++;
        }

        Console.WriteLine($"Even numbers count: {evenCount}");
        Console.WriteLine($"Odd numbers count: {oddCount}");

        // Keep the console open
        Console.ReadLine();
    }
}

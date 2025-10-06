using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int reversed = 0;
        int temp = Math.Abs(number); // Work with absolute value for reversal

        while (temp > 0)
        {
            int digit = temp % 10;     // Get the last digit
            reversed = (reversed * 10) + digit; // Append digit to reversed number
            temp /= 10;                // Remove last digit
        }

        // If original number was negative, make reversed number negative as well
        if (number < 0)
        {
            reversed = -reversed;
        }

        Console.WriteLine("Reversed number: " + reversed);

        Console.ReadLine();
    }
}

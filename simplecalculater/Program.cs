using System;

class Program
{
    static void Main()
    {
        double num1, num2, result;
        char operation;

        // Get first number from user
        Console.Write("Enter the first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        // Get second number from user
        Console.Write("Enter the second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        // Ask for the operation
        Console.Write("Enter an operator (+, -, *, /): ");
        operation = Convert.ToChar(Console.ReadLine());

        // Perform calculation based on the operation
        switch (operation)
        {
            case '+':
                result = num1 + num2;
                Console.WriteLine("Result: " + result);
                break;

            case '-':
                result = num1 - num2;
                Console.WriteLine("Result: " + result);
                break;

            case '*':
                result = num1 * num2;
                Console.WriteLine("Result: " + result);
                break;

            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.WriteLine("Result: " + result);
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;

            default:
                Console.WriteLine("Invalid operator. Please use +, -, *, or /.");
                break;
        }

        // Keep the console window open
        Console.ReadLine();
    }
}

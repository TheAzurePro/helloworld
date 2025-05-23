using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        if (!double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.WriteLine("Invalid input for first number.");
            return;
        }

        Console.WriteLine("Enter the second number:");
        if (!double.TryParse(Console.ReadLine(), out double num2))
        {
            Console.WriteLine("Invalid input for second number.");
            return;
        }

        Console.WriteLine("Select operation:");
        Console.WriteLine("1) Addition");
        Console.WriteLine("2) Subtraction");
        Console.WriteLine("3) Multiplication");
        Console.WriteLine("4) Division");
        string operation = Console.ReadLine();

        switch (operation)
        {
            case "1":
                Console.WriteLine($"The Sum of given 2 numbers is {num1 + num2}");
                break;
            case "2":
                Console.WriteLine($"The Result of subtracting 1st number from 2nd is {num2 - num1}");
                break;
            case "3":
                Console.WriteLine($"The Product of given 2 numbers is {num1 * num2}");
                break;
            case "4":
                if (num2 == 0)
                {
                    Console.WriteLine("Division not possible");
                }
                else
                {
                    Console.WriteLine($"The Division of 1st number with given 2nd number is {num1 / num2}");
                }
                break;
            default:
                Console.WriteLine("Invalid operation selected.");
                break;
        }
    }
}

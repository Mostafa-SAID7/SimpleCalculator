using System;

class Program
{
    static void Main()
    {
        bool running = true;

        while (running)
        {
            // Console.Clear();
            Console.WriteLine("== SIMPLE CALCULATOR ==");

            Console.Write("Enter first number: ");
            double num1 = GetNumber();

            Console.Write("Enter second number: ");
            double num2 = GetNumber();

            Console.WriteLine("Choose operation:");
            Console.WriteLine("1 - Addition (+)");
            Console.WriteLine("2 - Subtraction (-)");
            Console.WriteLine("3 - Multiplication (*)");
            Console.WriteLine("4 - Division (/)");
            Console.WriteLine("5 - Exit");

            Console.Write("Your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine($"Result: {Add(num1, num2)}");
                    break;
                case "2":
                    Console.WriteLine($"Result: {Subtract(num1, num2)}");
                    break;
                case "3":
                    Console.WriteLine($"Result: {Multiply(num1, num2)}");
                    break;
                case "4":
                    if (num2 != 0)
                        Console.WriteLine($"Result: {Divide(num1, num2)}");
                    else
                        Console.WriteLine("Error: Division by zero!");
                    break;
                case "5":
                    running = false;
                    continue;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }

    static double GetNumber()
    {
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out double number))
                return number;
            else
                Console.Write("Invalid input. Try again: ");
        }
    }

    static double Add(double a, double b) => a + b;
    static double Subtract(double a, double b) => a - b;
    static double Multiply(double a, double b) => a * b;
    static double Divide(double a, double b) => a / b;
}

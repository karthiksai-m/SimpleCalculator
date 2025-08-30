using System;

namespace Simple_Calculator
{
    internal class Program
    {
        static void Main()
        {
            Calculator.CalculatorApp calc = new Calculator.CalculatorApp();

            while (true)
            {
                Console.WriteLine("=== Simple Calculator ===");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine() ?? "0";
                Console.WriteLine();
                if (choice == "5")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                double num1;
                Console.Write("Enter first number: ");
                while (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.Write("Invalid input. Enter a valid number: ");
                }
                double num2;
                Console.Write("Enter second number: ");
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.Write("Invalid input. Enter a valid number: ");
                }
                double result = choice switch
                {
                    "1" => calc.Add(num1, num2),
                    "2" => calc.Subtract(num1, num2),
                    "3" => calc.Multiply(num1, num2),
                    "4" => calc.Divide(num1, num2),
                    _ => double.NaN
                };
                if (double.IsNaN(result))
                {
                    Console.WriteLine("Error: Invalid operation or division by zero.\n");
                }
                else
                {
                    Console.WriteLine($"Result: {result}\n");
                }
            }
        }
    }
}

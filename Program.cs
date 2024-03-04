using System;
using System.Data;
using ConsoleCalculator;
using Npgsql;

class Program
{
    static void Main(string[] args)
    {
        using (var dataSource = Helper.DataSource)
        {
            var calculatorRepository = new CalculatorRepository(dataSource);
            var calculator = new Calculator(calculatorRepository);

            Console.WriteLine("Enter first number:");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number:");

            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose operation (add, subtract, multiply, divide):");
            
            string operation = (Console.ReadLine()!.Trim()).ToLower();
            

            switch (operation)
            {
                case "add":
                    Console.WriteLine($"Result: {calculator.Add(n1, n2)}");
                    break;
                case "subtract":
                    Console.WriteLine($"Result: {calculator.Subtract(n1, n2)}");
                    break;
                case "multiply":
                    Console.WriteLine($"Result: {calculator.Multiply(n1, n2)}");
                    break;
                case "divide":
                        Console.WriteLine($"Result: {calculator.Divide(n1, n2)}");
                    break;
                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }
        }
    }
}

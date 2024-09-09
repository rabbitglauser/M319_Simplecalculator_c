using System;

class Calculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Samuel's calculator in C#. First, you have to input two numbers to calculate. You can choose to do a division, multiplication, etc.");

        Console.Write("Enter your first number: ");
        int userInput1;
        while (!int.TryParse(Console.ReadLine(), out userInput1))
        {
            Console.Write("Invalid input. Please enter a valid number: ");
        }

        Console.Write("Enter your second number: ");
        int userInput2;
        while (!int.TryParse(Console.ReadLine(), out userInput2))
        {
            Console.Write("Invalid input. Please enter a valid number: ");
        }

        Console.WriteLine("Choose an operation: + (Addition), - (Subtraction), * (Multiplication), / (Division)");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine();  // For newline after reading operation

        int result = 0;
        switch (operation)
        {
            case '+':
                result = userInput1 + userInput2;
                Console.WriteLine($"The result of the addition is {result}");
                break;

            case '-':
                result = userInput1 - userInput2;
                Console.WriteLine($"The result of the subtraction is {result}");
                break;

            case '*':
                result = userInput1 * userInput2;
                Console.WriteLine($"The result of the multiplication is {result}");
                break;

            case '/':
                if (userInput2 == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                else
                {
                    result = userInput1 / userInput2;
                    Console.WriteLine($"The result of the division is {result}");
                }
                break;

            default:
                Console.WriteLine("Invalid operation selected.");
                break;
        }
    }
}
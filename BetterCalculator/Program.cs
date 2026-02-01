/*
Abel Doyle
RCET 2265
Spring Semester 2026
BetterCalculator
https://github.com/abeldoyl/BetterCalculator.git
*/

using System;

namespace BetterCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter two numbers. Enter \"Q\" at any time to quit.");

            while (true)
            {
                // Get first number
                int firstNumber;
                if (!GetNumber(out firstNumber)) break;

                // Get second number
                int secondNumber;
                if (!GetNumber(out secondNumber)) break;

                // Get operation choice
                int choice = CalculatorOperation();

                // Perform calculation
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                        break;
                    case 2:
                        Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                        break;
                    case 3:
                        Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                        break;
                    case 4:
                        if (secondNumber == 0)
                        {
                            Console.WriteLine("Error: Cannot divide by zero.");
                        }
                        else
                        {
                            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                        }
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Press Enter to perform a new calculation");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Please enter two numbers. Enter \"Q\" at any time to quit.");
            }

            Console.WriteLine("Have a nice day");
            Console.WriteLine("Press enter to close this window");
            Console.ReadLine();
        }

        // Method to get and validate a whole number or quit
        static bool GetNumber(out int number)
        {
            number = 0;

            while (true)
            {
                Console.Write("Choose a Number: ");
                string input = Console.ReadLine();

                Console.WriteLine($"You entered \"{input}\"");

                if (input.Equals("Q", StringComparison.OrdinalIgnoreCase)) //StringComparison.OrdinalIgnoreCase is used to compare strings by character value not by upper/lower case
                {
                    return false;
                }

                if (int.TryParse(input, out number)) // if (int.TryParse(input, out number)) is for seeing if the text can be converted into a whole number, if it can store it and continue, otherwise handle the error
                {
                    return true;
                }

                Console.WriteLine($"You entered \"{input}\", please enter a whole number.");
            }
        }

        // Method to display menu and validate choice
        static int CalculatorOperation()
        {
            while (true)
            {
                Console.WriteLine("Choose one of the following options:");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");

                string input = Console.ReadLine();
                Console.WriteLine($"You entered \"{input}\"");

                if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 4) //if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 4) is used to accept the input only if it’s a whole number AND it’s one of the valid menu options (1–4)
                {
                    return choice;
                }

                Console.WriteLine("Invalid menu option. Please try again.");
            }
        }
    }
}

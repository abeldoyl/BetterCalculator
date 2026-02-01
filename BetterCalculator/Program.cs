/*
Abel Doyle
RCET 2265
Spring Semester 2026
BetterCalculator
*/

using System;

namespace BetterCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            int firstNumber, secondNumber;
            Console.WriteLine("Please enter a number");
            userInput = Console.ReadLine();
            firstNumber = int.Parse(userInput);
            Console.WriteLine($"You entered {firstNumber}");

            Console.WriteLine("Please enter a number");
            userInput = Console.ReadLine();
            secondNumber = int.Parse(userInput);
            Console.WriteLine($"You entered {secondNumber}");

            Console.WriteLine("Please enter a number for the an operation");
            Console.WriteLine("1. Sum");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Product");
            Console.WriteLine("4. Divistion");
            userInput = Console.ReadLine();


            switch (userInput)
            {
                case "1":
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                    break;
                case "2":
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                    break;
                case "3":
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                    break;
                default:
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                    break;
            }
            Console.ReadLine();
        }
    }
}

using System;

namespace IntroductionToProgramming
{
    public class BasicSyntax
    {
        public static void RunExample()
        {
            // 1. Variables and Data Types
            VariableExamples();

            // 2. Basic Arithmetic Operations
            ArithmeticOperations();

            // 3. Console Input/Output Example
            InputOutputExample();

            // 4. Simple Method Creation and Usage
            int sum = AddNumbers(5, 3);
            Console.WriteLine($"Method Example: Sum of 5 and 3 is {sum}");

            Console.WriteLine("\n-- Basic Syntax Examples Completed --");
        }

        // 1. Variables and Data Types Example
        private static void VariableExamples()
        {
            Console.WriteLine("\n-- Variables and Data Types --");

            // Declare variables of different data types
            int integer = 10;                  // Integer
            double floatingPoint = 20.5;       // Double (floating-point number)
            char singleCharacter = 'A';        // Character
            string text = "Hello, C#";         // String
            bool isProgrammingFun = true;      // Boolean (true/false)
            decimal myVar = 2351790;           // Decimal (used for money)

            // Print variable values
            Console.WriteLine($"Integer: {integer}");
            Console.WriteLine($"Double: {floatingPoint}");
            Console.WriteLine($"Character: {singleCharacter}");
            Console.WriteLine($"String: {text}");
            Console.WriteLine($"Boolean: {isProgrammingFun}");
            Console.WriteLine($"Decimal: {myVar}");
        }

        // 2. Basic Arithmetic Operations Example
        private static void ArithmeticOperations()
        {
            Console.WriteLine("\n-- Arithmetic Operations --");

            int a = 10;
            int b = 3;

            // Perform arithmetic operations and print results
            Console.WriteLine($"Addition: {a} + {b} = {a + b}");
            Console.WriteLine($"Subtraction: {a} - {b} = {a - b}");
            Console.WriteLine($"Multiplication: {a} * {b} = {a * b}");
            Console.WriteLine($"Division: {a} / {b} = {a / b}");      // Integer division
            Console.WriteLine($"Modulus: {a} % {b} = {a % b}");        // Remainder of division
        }

        // 3. Console Input/Output Example
        private static void InputOutputExample()
        {
            Console.WriteLine("\n-- Console Input/Output Example --");

            // Read input from the user and print a greeting message
            Console.Write("Enter your name: ");
            string? name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }

        // 4. Simple Method Example: Adding two numbers
        private static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}

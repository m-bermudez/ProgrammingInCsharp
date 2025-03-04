using System;

namespace IntroductionToProgramming
{
    public class VariablesAndDataTypes
    {
        // 1. Global variable (available to the whole class)
        static int globalVariable = 100;

        // 2. Constant and Readonly example
        const double Pi = 3.14159; // Constants are compile-time values
        static readonly string readonlyMessage = "This value is readonly"; // Can be assigned only in constructor or declaration
        const decimal my_var = 14;

        public static void RunExample()
        {
            // 1. Variable Scope and Lifetime
            ScopeAndLifetimeExample();

            // 2. Constant and Readonly Variables
            ConstantAndReadonlyExample();

            // 3. Enumerations (enum)
            EnumerationExample();

            // 4. Typecasting and Conversions
            TypecastingExample();

            // 5. Nullable Types
            NullableTypesExample();

            Console.WriteLine("\n-- Variables and Data Types Examples Completed --");
        }

        // 1. Variable Scope and Lifetime Example
        private static void ScopeAndLifetimeExample()
        {
            Console.WriteLine("\n-- Variable Scope and Lifetime --");

            // Local variable (only available within this method)
            int localVariable = 50;
            Console.WriteLine($"Local Variable: {localVariable}");

            // Accessing global variable
            Console.WriteLine($"Global Variable: {globalVariable}");

            // Local scope within a block (inside a loop or conditional)
            if (true)
            {
                int blockScopedVariable = 30;
                Console.WriteLine($"Block Scoped Variable: {blockScopedVariable}");
            }
            // blockScopedVariable is not accessible here, it goes out of scope after the block
        }

        // 2. Constant and Readonly Variables Example
        private static void ConstantAndReadonlyExample()
        {
            Console.WriteLine("\n-- Constant and Readonly Variables --");

            // Accessing constant
            Console.WriteLine($"Constant Pi: {Pi}");

            // Accessing readonly variable
            Console.WriteLine($"Readonly Message: {readonlyMessage}");
        }

        // 3. Enumerations Example (enum)
        private static void EnumerationExample()
        {
            Console.WriteLine("\n-- Enumerations (enum) Example --");

            Days today = Days.Wednesday;
            Console.WriteLine($"Today is: {today}");

            // Enum to int conversion
            int dayNumber = (int)Days.Wednesday;
            Console.WriteLine($"Wednesday is day number: {dayNumber}");
        }

        // Enum definition
        enum Days
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }

        // 4. Typecasting and Conversions Example
        private static void TypecastingExample()
        {
            Console.WriteLine("\n-- Typecasting and Conversions --");

            // Implicit casting (automatically done by C#)
            int num = 10;
            double doubleNum = num; // int to double (implicit)
            Console.WriteLine($"Implicit Casting: int {num} to double {doubleNum}");

            // Explicit casting (manual casting required)
            double preciseValue = 9.8;
            int roundedValue = (int)preciseValue; // double to int (explicit)
            Console.WriteLine($"Explicit Casting: double {preciseValue} to int {roundedValue}");

            // Using Convert class
            string strNumber = "123";
            int parsedNumber = Convert.ToInt32(strNumber); // String to int
            Console.WriteLine($"Convert.ToInt32: String '{strNumber}' to int {parsedNumber}");

            // Using int.Parse
            int parsedWithParse = int.Parse(strNumber);
            Console.WriteLine($"int.Parse: String '{strNumber}' to int {parsedWithParse}");

            // Handling invalid conversions (with exception handling)
            try
            {
                string invalidNumber = "ABC";
                int invalidConversion = int.Parse(invalidNumber); // This will throw an exception
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid string to int conversion attempted.");
            }
        }

        // 5. Nullable Types Example
        private static void NullableTypesExample()
        {
            Console.WriteLine("\n-- Nullable Types Example --");

            // Nullable int (can store null or an integer value)
            int? nullableInteger = null;
            Console.WriteLine($"Nullable Integer with null: {nullableInteger}");

            // Assigning a value to nullable
            nullableInteger = 10;
            Console.WriteLine($"Nullable Integer with value: {nullableInteger}");

            // Checking if the nullable has a value
            if (nullableInteger.HasValue)
            {
                Console.WriteLine($"Nullable integer has a value: {nullableInteger.Value}");
            }
            else
            {
                Console.WriteLine("Nullable integer has no value (null).");
            }
        }
    }
}

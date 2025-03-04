using System;

namespace DataStructures.Strings
{
    public class StringManipulation
    {
        public static void RunExample()
        {
            // 1. String Declaration and Initialization
            StringDeclarationInitialization();

            // 2. Common String Methods (Substring, Replace, IndexOf, Trim, etc.)
            CommonStringMethods();

            // 3. String Interpolation and Concatenation
            StringInterpolationConcatenation();

            // 4. String Comparison (CompareTo and Equals)
            StringComparisonExample();

            // 5. String Immutability Example
            StringImmutabilityExample();

            Console.WriteLine("\n-- String Manipulation Examples Completed --");
        }

        // 1. String Declaration and Initialization
        private static void StringDeclarationInitialization()
        {
            Console.WriteLine("\n-- String Declaration and Initialization --");

            // String declaration and initialization
            string message = "Hello, C#!";
            string emptyString = ""; // Empty string
            string? nullString = null; // Null string

            Console.WriteLine($"Message: {message}");
            Console.WriteLine($"Empty String: '{emptyString}'");
            Console.WriteLine($"Null String: {nullString}");
        }

        // 2. Common String Methods (Substring, Replace, IndexOf, Trim, etc.)
        private static void CommonStringMethods()
        {
            Console.WriteLine("\n-- Common String Methods --");

            string sample = "   C# Programming is fun!   ";

            // Trim - Removes leading and trailing spaces
            string trimmed = sample.Trim();
            Console.WriteLine($"Trimmed: '{trimmed}'");

            // Substring - Extracts a substring from a string
            string substring = sample.Substring(4, 11); // Starting from index 4, length 11
            Console.WriteLine($"Substring: '{substring}'");

            // Replace - Replaces all occurrences of a substring
            string replaced = sample.Replace("fun", "awesome");
            Console.WriteLine($"Replaced: '{replaced}'");

            // IndexOf - Finds the index of a substring
            int index = sample.IndexOf("Programming");
            Console.WriteLine($"Index of 'Programming': {index}");
        }

        // 3. String Interpolation and Concatenation
        private static void StringInterpolationConcatenation()
        {
            Console.WriteLine("\n-- String Interpolation and Concatenation --");

            string name = "Alice";
            int age = 25;

            // String Interpolation
            string interpolated = $"My name is {name} and I am {age} years old.";
            Console.WriteLine($"Interpolated String: {interpolated}");

            // String Concatenation using +
            string concatenated = "My name is " + name + " and I am " + age + " years old.";
            Console.WriteLine($"Concatenated String: {concatenated}");

            // String Concatenation using string.Concat()
            string concatMethod = string.Concat("Hello ", name, ", welcome to C#!");
            Console.WriteLine($"Concat Method: {concatMethod}");
        }

        // 4. String Comparison (CompareTo and Equals)
        private static void StringComparisonExample()
        {
            Console.WriteLine("\n-- String Comparison (CompareTo and Equals) --");

            string str1 = "Hello";
            string str2 = "hello";
            string str3 = "Hello";

            // CompareTo - Compares two strings lexicographically
            int comparison = str1.CompareTo(str2); // Case-sensitive comparison
            Console.WriteLine($"CompareTo result (str1 vs str2): {comparison}");

            // Equals - Checks if two strings are equal
            bool isEqual = str1.Equals(str2, StringComparison.OrdinalIgnoreCase); // Case-insensitive comparison
            Console.WriteLine($"Equals result (str1 vs str2, case-insensitive): {isEqual}");

            bool isEqualExact = str1.Equals(str3); // Case-sensitive comparison
            Console.WriteLine($"Equals result (str1 vs str3, case-sensitive): {isEqualExact}");
        }

        // 5. String Immutability Example
        private static void StringImmutabilityExample()
        {
            Console.WriteLine("\n-- String Immutability Example --");

            // Strings in C# are immutable
            string original = "Immutable String";
            string modified = original.Replace("Immutable", "Mutable?");

            // The original string remains unchanged
            Console.WriteLine($"Original String: {original}");
            Console.WriteLine($"Modified String: {modified}");
        }
    }
}

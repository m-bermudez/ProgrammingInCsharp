using System;
using System.Collections.Generic;

namespace DataStructures.Dictionaries
{
    public class DictionaryOperations
    {
        public static void RunExample()
        {
            // 1. Dictionary Declaration and Initialization
            DictionaryDeclarationInitialization();

            // 2. Adding, Removing, and Updating Elements
            AddRemoveUpdateElements();

            // 3. Key-Based Lookup (TryGetValue)
            KeyBasedLookup();

            // 4. Iterating Through Dictionaries (foreach)
            DictionaryIteration();

            // 5. Dictionary Performance Considerations
            PerformanceConsiderations();

            Console.WriteLine("\n-- Dictionary Operations Examples Completed --");
        }

        // 1. Dictionary Declaration and Initialization
        private static void DictionaryDeclarationInitialization()
        {
            Console.WriteLine("\n-- Dictionary Declaration and Initialization --");

            // Declaration and initialization with key-value pairs
            Dictionary<int, string> studentGrades = new Dictionary<int, string>
            {
                { 1, "A" },
                { 2, "B" },
                { 3, "C" }
            };

            // Accessing elements by key
            Console.WriteLine($"Student 1's grade: {studentGrades[1]}");
            Console.WriteLine($"Student 2's grade: {studentGrades[2]}");
            Console.WriteLine($"Student 3's grade: {studentGrades[3]}");
        }

        // 2. Adding, Removing, and Updating Elements in a Dictionary
        private static void AddRemoveUpdateElements()
        {
            Console.WriteLine("\n-- Adding, Removing, and Updating Elements --");

            Dictionary<int, string> studentGrades = new Dictionary<int, string>();

            // Adding elements
            studentGrades.Add(1, "A");
            studentGrades.Add(2, "B");

            Console.WriteLine("After adding:");
            foreach (var kvp in studentGrades)
            {
                Console.WriteLine($"Student {kvp.Key}'s grade: {kvp.Value}");
            }

            // Updating an existing element
            studentGrades[2] = "A+";
            Console.WriteLine("\nAfter updating student 2's grade:");
            Console.WriteLine($"Student 2's new grade: {studentGrades[2]}");

            // Removing an element
            studentGrades.Remove(1);
            Console.WriteLine("\nAfter removing student 1:");
            foreach (var kvp in studentGrades)
            {
                Console.WriteLine($"Student {kvp.Key}'s grade: {kvp.Value}");
            }
        }

        // 3. Key-Based Lookup (TryGetValue)
        private static void KeyBasedLookup()
        {
            Console.WriteLine("\n-- Key-Based Lookup (TryGetValue) --");

            Dictionary<int, string> studentGrades = new Dictionary<int, string>
            {
                { 1, "A" },
                { 2, "B" },
                { 3, "C" }
            };

            // Using TryGetValue to safely get values
            if (studentGrades.TryGetValue(2, out string? grade))
            {
                Console.WriteLine($"Student 2's grade: {grade}");
            }
            else
            {
                Console.WriteLine("Student 2's grade not found.");
            }

            // Attempting to access a non-existent key
            if (!studentGrades.TryGetValue(4, out grade))
            {
                Console.WriteLine("Student 4's grade not found.");
            }
        }

        // 4. Iterating Through Dictionaries (foreach)
        private static void DictionaryIteration()
        {
            Console.WriteLine("\n-- Iterating Through Dictionaries (foreach) --");

            Dictionary<int, string> studentGrades = new Dictionary<int, string>
            {
                { 1, "A" },
                { 2, "B" },
                { 3, "C" }
            };

            // Iterating through the dictionary
            foreach (KeyValuePair<int, string> kvp in studentGrades)
            {
                Console.WriteLine($"Student {kvp.Key}: {kvp.Value}");
            }
        }

        // 5. Dictionary Performance Considerations
        private static void PerformanceConsiderations()
        {
            Console.WriteLine("\n-- Dictionary Performance Considerations --");

            // Dictionaries provide O(1) lookup, addition, and deletion (on average)
            Dictionary<int, string> largeDictionary = new Dictionary<int, string>();

            // Adding 1 million entries to simulate a large dictionary
            for (int i = 1; i <= 1000000; i++)
            {
                largeDictionary.Add(i, $"Student {i}");
            }

            // Measure the time it takes to retrieve an entry
            var watch = System.Diagnostics.Stopwatch.StartNew();
            string student999999 = largeDictionary[999999];
            watch.Stop();

            Console.WriteLine($"Retrieved Student 999999 in {watch.ElapsedTicks} ticks.");
        }
    }
}

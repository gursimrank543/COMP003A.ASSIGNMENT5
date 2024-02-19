/*
 * Author: Gursimran Kaur
 * Course: COMP-003A
 * Purpose: COMP003A.ASSIGNMENT5
 */

using System;

namespace COMP003A.ASSIGNMENT5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Call the PrintSeparator() method, and pass on the parameter "Triangle".
            PrintSeparator("Triangle");

            // Request a single character input from the user, convert the response to a character, and store it in a variable name of your choice.
            Console.Write("Enter a character for the triangle: ");
            char triangleCharacter = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // Request a positive whole number input from the user, convert the response to an integer, and store it in a variable name of your choice.
            Console.Write("Enter the size of the triangle: ");
            int triangleSize = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Call the IsoscelesTriangleBuilder() method, and use the two variables you just stored as parameters.
            IsoscelesTriangleBuilder(triangleCharacter, triangleSize);

            // Call the PrintSeparator() method again, and pass on the parameter "Favorite Characters".
            PrintSeparator();

            // Call the CharacterInfo() method at least 5 times, passing your favorite characters and the year of their birth or first appearance.
            PrintSeparator("Favorite Characters");

            CharacterInfo("Mario", 1981);
            CharacterInfo("Mickey Mouse", 1928);
            CharacterInfo("Spider-Man", 1962);
            CharacterInfo("SpongeBob SquarePants", 1999);
            CharacterInfo("Harry Potter", 1997);
        }

        /// <summary>
        /// Outputs a separator line of asterisks.
        /// </summary>
        static void PrintSeparator() // 3rd point
        {
            Console.WriteLine(new string('*', 50)); // 50 asterisks
        }

        /// <summary>
        /// Outputs a separator line of the specified character.
        /// </summary>
        /// <param name="separator">The character used for the separator.</param>
        static void PrintSeparator(string separator) // 4th point
        {
            Console.WriteLine(new string(separator[0], 50)); // 50 characters of the specified string
        }

        /// <summary>
        /// Builds an isosceles triangle using the specified character and size.
        /// </summary>
        /// <param name="inputCharacter">The character used to build the triangle.</param>
        /// <param name="size">The size of the triangle.</param>
        static void IsoscelesTriangleBuilder(char inputCharacter, int size) // 5th point
        {
            for (int i = 1; i <= size; i++)
            {
                Console.WriteLine(new string(inputCharacter, i));
            }

            for (int i = size - 1; i >= 1; i--)
            {
                Console.WriteLine(new string(inputCharacter, i));
            }
        }

        /// <summary>
        /// Calculates the age based on the given year.
        /// </summary>
        /// <param name="year">The year of birth or appearance.</param>
        /// <returns>The calculated age.</returns>
        static int AgeCalculator(int year) // 6th point
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - year;
        }

        /// <summary>
        /// Displays the name and age of a character based on the given birth year.
        /// </summary>
        /// <param name="name">The name of the character.</param>
        /// <param name="birthYear">The year of birth or first appearance of the character.</param>
        static void CharacterInfo(string name, int birthYear) // 7th point
        {
            int age = AgeCalculator(birthYear);
            Console.WriteLine($"Character: {name}, Age: {age} years old");
        }
    }
}
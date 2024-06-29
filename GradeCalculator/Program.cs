using System;

namespace GradeCalcul
{
    class Program
    {
        static void Main(string[] args)
        {

            // Prompt user to enter their grade
            Console.Write("Enter your  grade (0-100): ");

            // Read input from the user
            string? input = Console.ReadLine();

            // Check if the input is not null or empty
            if (!string.IsNullOrEmpty(input))
            {
                // Try to parse the input to an integer
                if (int.TryParse(input, out int grade))
                {
                    // Determine the letter grade based on the numerical grade
                    string letterGrade;

                    if (grade >= 90)
                    {
                        letterGrade = "A";
                    }
                    else if (grade >= 80)
                    {
                        letterGrade = "B";
                    }
                    else if (grade >= 70)
                    {
                        letterGrade = "C";
                    }
                    else if (grade >= 60)
                    {
                        letterGrade = "D";
                    }
                    else
                    {
                        letterGrade = "F";
                    }

                    // Display the letter grade
                    Console.WriteLine($"Your letter grade is: {letterGrade}");
                }
                else
                {
                    // Handle the case where the input is not a valid number
                    Console.WriteLine("Invalid input. Please enter a valid numerical grade.");
                }
            }
            else
            {
                // Handle the case where the input is null or empty
                Console.WriteLine("No input provided. Please enter a numerical grade.");
            }
        }
    }
}

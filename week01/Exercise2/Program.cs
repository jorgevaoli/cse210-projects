using System;

class GradeCalculator
{
    static void Main()
    {
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int gradePercentage;

        if (int.TryParse(input, out gradePercentage))
        {
            string letter = "";

            if (gradePercentage >= 90)
            {
                letter = "A";
            }
            else if (gradePercentage >= 80)
            {
                letter = "B";
            }
            else if (gradePercentage >= 70)
            {
                letter = "C";
            }
            else if (gradePercentage >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            Console.WriteLine($"Your letter grade is: {letter}");

            if (gradePercentage >= 70)
            {
                Console.WriteLine("Congratulations! You passed the class.");
            }
            else
            {
                Console.WriteLine("Keep trying! You can do better next time.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
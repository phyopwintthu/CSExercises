using System;
namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Plese Enter the marks");
            int marks = Convert.ToInt16(Console.ReadLine());

            if (marks < 0 || marks > 100)
            {
                Console.WriteLine("Incorrect Marks");
            }
            else if (marks >= 80 && marks <= 100)
            {
                Console.WriteLine("Grade A");
            }
            else if (marks >= 60 && marks <= 79)
            {
                Console.WriteLine("Grade B");
            }
            else if (marks >= 41 && marks <= 59)
            {
                Console.WriteLine("Grade C");
            }
            else if (marks >= 0 && marks <= 40)
            {
                Console.WriteLine("Fail");
            }      
        }
    }
}
using System;
namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Plese Enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("Plese Enter the gender(M or F)");
            string gender = Console.ReadLine();
            Console.WriteLine("Plese Enter the age");
            int age = Convert.ToInt16(Console.ReadLine());

            if (gender == "M" && age >= 40)
            {
                Console.WriteLine("Good Morning Uncle {0}", name);
            }
            else if (gender == "F" && age >= 40)
            {
                Console.WriteLine("Good Morning Aunty {0}", name);
            }
            else if (gender == "F")
            {
                Console.WriteLine("Good Morning Ms.{0}", name);
            }
            else if (gender == "M")
            {
                Console.WriteLine("Good Morning Mr.{0}", name);
            }
            else
            {
                Console.WriteLine("Do not match with request.");
            }
        }
    }
}
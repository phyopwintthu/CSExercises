using System;
namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Plese Enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("Plese Enter the gender(M or F)");
            string gender = Console.ReadLine();

            if(gender == "F")
            {
                Console.WriteLine("Ms. {0}",name);
            }
            else if (gender == "M")
            {
                Console.WriteLine("Mr. {0}", name);
            }
            else
            {
                Console.WriteLine("Do not match with request.");
            }
        }
    }
}
using System;
namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            int num;
            do
            {
                Console.WriteLine("Please Enter the secret number");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num != 88);
            Console.WriteLine("You Got it"); 
        }
    }
}

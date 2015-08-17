using System;
namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random ran = new Random();
            int witch = ran.Next(0, 9);
            Console.WriteLine(witch);
            int guess_num;
            int count = 1;

            do
            {
                Console.WriteLine("Please enter the guess number");
                guess_num = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("The total attempts {0}", count++);
                int total_count = count++;

                if (total_count == 1 && guess_num == witch)
                {
                    Console.WriteLine("You are a wizard!");
                }
                else if (total_count == 2 && guess_num == witch)
                {
                    Console.WriteLine("You are a good guess!");
                }
                else if (total_count >= 3 && guess_num == witch)
                {
                    Console.WriteLine("You are Lousy!");
                }
                else if (guess_num != witch)
                {
                    Console.WriteLine("Try Again");
                }
                else
                {
                    Console.WriteLine("The total attempts {0}", total_count);
                }
            } while (guess_num != witch);
            Console.WriteLine("Congratulation. You Got it");
        }
    }
}

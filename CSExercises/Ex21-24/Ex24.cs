using System;
namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            //double sqrt_num = Math.Sqrt(num);
            Random ran = new Random();
            double guess_num = ran.Next(1, num);
            Console.WriteLine(guess_num);
            
            do
            {
                if (Math.Pow(guess_num, 2) == num)
                {
                    Console.WriteLine("guess_num {0} is square root of {1}",guess_num,num);
                }

            } while (guess_num appro num);
            Console.WriteLine("You Got This");
        }
    }
}

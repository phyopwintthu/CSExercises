using System;
namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            Random ran = new Random();
            double guess = ran.Next(1, num);
            Console.WriteLine("The Guess number {0}", guess);


           while (guess * guess != num && Math.Round(guess * guess, 5) != num)
           {
                guess = (guess + num / guess) / 2;
           }
            Console.WriteLine("The root of this square number {0} is {1:0.000000}\n", num,guess);
         }
    }
}

using System;
namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Please enter the prime number");
            int num = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine("This is prime number");
                }
                else
                {
                    Console.WriteLine("This is not prime number");
                }
          }
    }
}

using System;
namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int total = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    total += i;
                }
            }
            if(total == num)
            {
                Console.WriteLine("This is Prime Number");
            }
            else
            {
                Console.WriteLine("This is not Prime Number");
            }
        }
    }
}

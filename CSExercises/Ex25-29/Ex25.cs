using System;
namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int fac = 1;
            for (int i = 1; i <= num; i++)
            {
                fac = fac * i;
            }
            Console.WriteLine("The facorial of {0} is {1}.", num, fac);

            for (int j = num; j <= 1; j--)
            {
                fac = fac * j;                
            }
            Console.WriteLine("The reverse facorial of {0} is {1}.", num, fac);

        }
    }
}

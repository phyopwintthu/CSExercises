using System;
namespace CSExercises
{
    public class Ex39
    {
        public static void Main(string[] args)
        {
            long n = GetInputFromUser("Please enter the number");
            
            long fac = Factorial(n);
            Console.WriteLine("The facorial of {0} is {1}.", n, fac);
        }
        public static long GetInputFromUser(string prompt)
        {
            Console.WriteLine(prompt);
            long n = Convert.ToInt32(Console.ReadLine());

            return n;
        }
        public static long Factorial(long n)
        {
            long fac = 1;
            for (int i = 1; i <= n; i++)
            {
                fac = fac * i;
            }            
            
            return fac;
        }
    }
}

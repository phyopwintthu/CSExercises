using System;
namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("NO\t\tINVERSE\t\tSQUARE ROOT\t\tSQUARE");
            for (double i=1; i <= 10; i++)
            {
                Console.WriteLine("{0:#.0}\t\t{1:#0.###}\t\t{2:#0.###}\t\t\t{3:#0.0}",i,Math.Round(1/i,3),Math.Sqrt(i),Math.Pow(i,2));
            }
        }
    }
}

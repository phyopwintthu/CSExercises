using System;
namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Program a");
            Console.WriteLine("X\t\tY\n--------------------------------------");
            for (int x = -5; x<= 5; x++)
            {
              double y = (2 * Math.Pow(x, 2)) - (4 * x) + 3;
              Console.WriteLine("{0:#0.0}\t\t{1:#0.0}",x,y);
            }

            Console.WriteLine("Program b");
            for (int x = 1; x <= 20; x++)
            {
                double y = (2 * Math.Pow(x, 2)) - (4 * x) + 3;

            }
        }
    }
}

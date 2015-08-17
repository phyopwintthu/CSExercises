using System;
namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Plese Enter the distance in Kilometers");
            double dis_kilo = Convert.ToDouble(Console.ReadLine());
            double dis_round = Math.Ceiling(dis_kilo*10)/10;

            if (dis_round <= 0.5)
            {
                double fare_cost = 2.4;
                Console.WriteLine("Fare Cost ${0}", fare_cost);
            }
            else if (dis_round >= 0.51 && dis_round <= 8.5)
            {
                double fare_cost = 2.4 + (dis_round - 0.5) * 10 * 0.04;
                Console.WriteLine("Fare Cost ${0}", fare_cost);
            }
            else if (dis_round >= 8.51)
            {
                double fare_cost = 2.4 + (85 * 0.04) + (dis_round * 10 - 90) * 0.05;
                Console.WriteLine("Fare Cost ${0}", fare_cost);
            }
            else
            {
                Console.WriteLine("Errors");
            }
        }
    }
}
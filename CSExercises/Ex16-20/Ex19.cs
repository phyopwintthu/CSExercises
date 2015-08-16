using System;
namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Plese Enter the distance in Kilometers");
            double dis_kilo = Convert.ToDouble(Console.ReadLine());
            double dis_meters = dis_kilo * 1000; 

            if (dis_meters <= 500 )
            {
                double fare_cost = 2.4;
                Console.WriteLine("Fare Cost ${0}", fare_cost);
            }
            else if (dis_meters >= 501 && dis_meters <= 850) {
                double fare_cost = 2.4 + (dis_meters/10)*0.04;
                Console.WriteLine("Fare Cost ${0}", fare_cost);
            }
            else if (dis_meters >= 851)
            {
                //double fare_cost1 = 2.4 + (dis_meters / 10) * 0.04;
                //double fare_cost2 = 2.4 + ((dis_meters-850)/10) * 0.05;
                //double fare_cost = fare_cost1 + fare_cost2;
               // Console.WriteLine("Fare Cost ${0}", fare_cost);
            }
            else
            {
                Console.WriteLine("Errors");
            }
        }
    }
}
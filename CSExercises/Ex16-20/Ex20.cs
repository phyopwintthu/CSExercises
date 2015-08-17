using System;
namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Plese Enter the quantity for TV");
            int q_tv = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Plese Enter the quantity for DVD");
            int q_dvd = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Plese Enter the quantity for MP3");
            int q_mp3 = Convert.ToInt16(Console.ReadLine());

            int total = q_tv*900 + q_dvd*500 + q_mp3*700;
            Console.WriteLine("Total Price for this order is ${0}", total);

            int total2 = q_tv*900 + q_dvd*500;

            if (total2 >= 5000 && total2 <= 9999)
            {
                double dis = total2 * 0.10;
                double total_all = total2 - dis;
                Console.WriteLine("TV and DVD amount including discount for > 5000 ${0}", total_all + q_mp3 * 700);
            }
            else if (total2 >= 10000)
            {
                double dis = total2 * 0.15;
                double total_all = total2 - dis;
                Console.WriteLine("TV and DVD amount including discount for > 10000 ${0}", total_all + q_mp3 * 700);
            }
            

        }
    }
}
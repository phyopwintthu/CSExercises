using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please the distance of fare");
            string dis_string = Console.ReadLine();
            double dis_num = Convert.ToDouble(dis_string);
            double total_fare = 2.40 + (dis_num * 0.4);
            Console.WriteLine("the distance: " + dis_num);
            Console.WriteLine("the totalfare: " + total_fare);
        }
    }
}

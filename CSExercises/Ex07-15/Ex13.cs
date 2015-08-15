using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please the distance of fare");
            string dis_string = Console.ReadLine();
            double dis_num = Convert.ToDouble(dis_string);
            double fare = 2.40 + (dis_num * 0.4);
            Console.WriteLine("the distance: {0}", dis_num);
            Console.WriteLine("the totalfare: {0:0.#0}", fare);
        }
    }
}

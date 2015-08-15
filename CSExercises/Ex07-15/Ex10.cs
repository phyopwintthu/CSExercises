using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please the value of x1");
            string x1_string = Console.ReadLine();
            Console.WriteLine("Please the value of y1");
            string y1_string = Console.ReadLine();
            Console.WriteLine("Please the value of x2");
            string x2_string = Console.ReadLine();
            Console.WriteLine("Please the value of y2");
            string y2_string = Console.ReadLine();

            double x1_num = Convert.ToDouble(x1_string);
            double y1_num = Convert.ToDouble(y1_string);
            double x2_num = Convert.ToDouble(x2_string);
            double y2_num = Convert.ToDouble(y2_string);
            double distance = Math.Sqrt( Math.Pow(x2_num - x1_num,2) + Math.Pow(y2_num - y1_num, 2) );

            Console.WriteLine("the value of x1: {0}", x1_num);
            Console.WriteLine("the value of y1: {0}", y1_num);
            Console.WriteLine("the value of x2: {0}", x2_num);
            Console.WriteLine("the value of y2: {0}", y2_num);
            Console.WriteLine("the distance is: {0}", distance);
        }
    }
}

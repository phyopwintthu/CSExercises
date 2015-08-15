using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please the length a");
            string a_string = Console.ReadLine();

            Console.WriteLine("Please the length b");
            string b_string = Console.ReadLine();

            Console.WriteLine("Please the length c");
            string c_string = Console.ReadLine();

            double a_num = Convert.ToDouble(a_string);
            double b_num = Convert.ToDouble(b_string);
            double c_num = Convert.ToDouble(c_string);

            double lengths = (a_num+b_num+c_num)/2;
            double area = Math.Sqrt(lengths*(lengths-a_num)*(lengths-b_num)*(lengths-c_num));
            Console.WriteLine("the distance: " + lengths);
            Console.WriteLine("the Area: " + area);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please the value of x");
            string x_string = Console.ReadLine();
            double x_num = Convert.ToDouble(x_string);
            double y_num = (2 * Math.Pow(x_num,2)) - (4 * x_num) + 3;
            Console.WriteLine("the value of x: {0}" ,x_num);
            Console.WriteLine("the value of y: {0}" ,y_num);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            int num;
            System.Console.Write("Please enter number ");
            string str = Console.ReadLine();
            try
            {
               num = Convert.ToInt32(str);
            }
            catch
            {
                num = 0;
            }
            double square = Math.Sqrt(num);
            System.Console.WriteLine("{0}", square);
        }
    }
}

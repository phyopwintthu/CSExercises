using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Write Centigrade");
            string centi = Console.ReadLine();
            double centigrade = Convert.ToDouble(centi);
            double fahrenheit = (1.8 * centigrade) + 32;
            Console.WriteLine("Centigrade: {0}" , centigrade);
            Console.WriteLine("Fahrenheit: {0}" , fahrenheit);
        }
    }
}

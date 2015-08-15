using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
              System.Console.Write("Please enter interger ");
              string str = Console.ReadLine();
              int num = Convert.ToInt32(str);
              double Sqr = Math.Pow(num,2);
              System.Console.WriteLine(Sqr);
        }
    }
}

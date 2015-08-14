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
              int num;
              System.Console.Write("Please enter interger ");
              string str = Console.ReadLine();
              num = Convert.ToInt16(str);
              System.Console.WriteLine(num * num);
        }
    }
}

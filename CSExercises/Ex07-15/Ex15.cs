using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            double sum = 0;
            int remainder = 0;
            Console.WriteLine("Please Enter the number");
            string num_string = Console.ReadLine();
            int num = Convert.ToInt32(num_string);
            for(int i = num; i > 0; i = i / 10)
            {
                remainder = i % 10;
                sum += Math.Pow(remainder, 3);                
            }

            if(sum==num)
            {
                Console.WriteLine("This is Armstrong Number");
            }
            else
            {
                Console.WriteLine("This is not Armstrong Number");
            }

        }
    }
}
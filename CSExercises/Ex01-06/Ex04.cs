﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            double num;
            System.Console.Write("Please enter double number ");
            string str = Console.ReadLine();
            try
            {
                num = Convert.ToDouble(str);
            }
            catch
            {
                num = 0;
            }
            double square = Math.Sqrt(num);
            Console.WriteLine("{0}", square);
            
        }
    }
}

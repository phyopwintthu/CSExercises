using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Write Salary");
            string sal = Console.ReadLine();
            double salary = Convert.ToDouble(sal);
            double house_allow = salary * 0.1;
            double trans_allow = salary * 0.03;
            double total_income = salary + house_allow + trans_allow;
            Console.WriteLine("Your Salary: " + salary);
            Console.WriteLine("Your House Allowance: " + house_allow);
            Console.WriteLine("Your Transportaion Allowance: " + trans_allow);
            Console.WriteLine("Your Total Income: " + total_income);
        }
    }
}

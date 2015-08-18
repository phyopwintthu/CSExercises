using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            double[] sales = new double[12];
            for (int i = 0; i < sales.Length; i++)
            {
                Console.WriteLine("Plese sales for month {0}",i);
                double sales_input = Convert.ToDouble(Console.ReadLine());
                sales[i] = sales_input;
            }
            double sum = 0;
            for (int j = 0; j < sales.Length; j++)
            {
                Console.WriteLine("Plese sales for month is {0}", j);
                sum += sales[j];               
            }
             double maxValue = sales.Max();
             double maxIndex = sales.ToList().IndexOf(maxValue);

             double minValue = sales.Min();
             double minIndex = sales.ToList().IndexOf(minValue);

             Console.WriteLine("Maximun Sales: {0}", maxIndex);
             Console.WriteLine("Minimun Sales: {0}", minIndex);
             Console.WriteLine("Average Sales: {0:##.###}",sum/12);
        }
    }
}

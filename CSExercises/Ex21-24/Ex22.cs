using System;
namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Plese Enter the number A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Plese Enter the number B");
            int b = Convert.ToInt32(Console.ReadLine());
            int ab = a * b;

            while (a != b)
            {
                if (a > b)
                {
                   a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            double lcm = ab / a;

            Console.WriteLine(a);
            Console.WriteLine(lcm);


            


            

            
        }
    }
}

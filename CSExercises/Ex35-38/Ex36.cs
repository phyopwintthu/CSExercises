using System;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            string reverse = "";
            string reverse2 = "";
            Console.WriteLine("Program a\n........................");
            Console.WriteLine("please enter the palidrome words");
            string pali = Console.ReadLine();
            for (int i = pali.Length-1; i >= 0; i--)
            {
                reverse += pali[i];
            }
            if (pali == reverse)
            {
                Console.WriteLine("This is Palidrome Number");
            }
            else
            {
                Console.WriteLine("This is Not Palidrome Number");
            }
            Console.WriteLine("\nProgram b\n........................");
            Console.WriteLine("please enter the palidrome sentance");
            string pali_sen = Console.ReadLine();
            string lower_sen = pali_sen.ToLower();

            string result = lower_sen.Replace(" ", "").Replace(".", "");

            Console.WriteLine(result);

            for (int j = result.Length-1; j >= 0; j--)
            {
                reverse2 += result[j];
            }
            if (result == reverse2)
            {
                Console.WriteLine("This is Palidrome Number");
            }
            else
            {
                Console.WriteLine("This is Not Palidrome Number");
            }
        }
    }
}

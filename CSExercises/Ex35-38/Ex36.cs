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
                reverse += pali.Substring(i, 1);
            }
            if (pali == reverse)
            {
                Console.WriteLine("This is Palidrome Word");
            }
            else
            {
                Console.WriteLine("This is Not Palidrome Word");
            }
            Console.WriteLine("\nProgram b\n........................");
            Console.WriteLine("please enter the palidrome sentance");
            string pali_sen = Console.ReadLine();
            string lower_sen = pali_sen.ToLower();
           // char[] x = new char[] { ' ' };


           // string[] lower_sen = pali_sen.ToLower().Split(x, StringSplitOptions.RemoveEmptyEntries);

           // //string[] arr = a.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

           //// string result = lower_sen.Replace(" ", "").Replace(".", "");

            for (int k = 0; k < lower_sen.Length; k++)
            {
                if (lower_sen[k] >= 'a' && lower_sen[k] <= 'z')
                {
                    string last += lower_sen[k].ToString();                   
                }
               

            }

            for (int j = lower_sen.Length - 1; j >= 0; j--)
            {
                reverse2 += lower_sen.Substring(j, 1);
            }
            if (lower_sen == reverse2)
            {
                Console.WriteLine("This is Palidrome Sentence");
            }
            else
            {
                Console.WriteLine("This is Not Palidrome Sentence");
            }

            //Console.WriteLine(lower_sen);

            //for (int j = lower_sen.Length - 1; j >= 0; j--)
            //{
            //    reverse2 += lower_sen.Substring(j, 1);
            //}
            //if (lower_sen == reverse2)
            //{
            //    Console.WriteLine("This is Palidrome Sentence");
            //}
            //else
            //{
            //    Console.WriteLine("This is Not Palidrome Sentence");
            //}
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            string reverse2 = "";

            Console.WriteLine("please enter the palidrome");
            string pali = Console.ReadLine();
            string lower = pali.ToLower();

            //Regex rgx = new Regex("[^a-z0-9\\w]");
            //string result = rgx.Replace(lower, "");

            string b = "";
            string[] res = lower.Split(' ','.');

            for (int i = 0; i < res.Length; i++)
            {
                string word = res[i];

                b = b + word;

            }

            for (int j = b.Length - 1; j >= 0; j--)
            {
                reverse2 += b.Substring(j, 1);
            }
            if (b.Equals(reverse2))
            {
                Console.WriteLine("This is Palidrome Sentence");
            }
            else
            {
                Console.WriteLine("This is Not Palidrome Sentence");
            }

         }
    }
}

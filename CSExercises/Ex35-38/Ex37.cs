using System;
namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            string b = "";
            Console.WriteLine("please enter the sentence");
            string sen = Console.ReadLine();
            string[] s = sen.Split(' ');
            for (int i = 0; i < s.Length; i++)
            {
                string word = s[i];
                if (word.Length > 1)
                {
                    word = word.ToUpper().Substring(0, 1) + word.Substring(1, word.Length - 1);
                    b = b + word+ " ";
                }
            }
            Console.WriteLine(b);
        }
    }
}

using System;
namespace CSExercises
{
    public class Ex44
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the String");
            string sen =Console.ReadLine();

            Console.WriteLine("Please Enter the char");
            char ch1 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Please Enter the char to change");
            char ch2 = Convert.ToChar(Console.ReadLine());

            string result = Substitute(sen,ch1,ch2);

            Console.WriteLine(result);
        }
        public static string Substitute(string s, char c1, char c2)
        {
            char[] sen = s.ToCharArray();
            string result = "";
            for (int i = 0; i < sen.Length; i++)
            {
                if(sen[i] == c1)
                {
                    sen[i] = c2;
                }
                result += sen[i];
            }
            return result;
        }
    }
}

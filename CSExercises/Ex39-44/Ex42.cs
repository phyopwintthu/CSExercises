using System;
namespace CSExercises
{
    public class Ex42
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The String 1:");
            string n1 = Console.ReadLine();
            Console.WriteLine("Please Enter The String 2:");
            string n2 = Console.ReadLine();
            int result = FindWord(n1, n2);

            if (result == -1)
            {
                Console.WriteLine("String 2 does not occurs in String 1");
            }
            else
            {
                Console.WriteLine("String 2 occurs in String 1 and the first position is {0}", result);
            }

        }
        
        public static int FindWord(string s1, string s2)
        {
            //int count = 0;
            string[] s1_arr = s1.ToLower().Split(' ');
            string[] s2_arr = s2.ToLower().Split(' ');
            return -1;
        }
    }
}

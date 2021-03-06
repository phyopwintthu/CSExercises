using System;
namespace CSExercises
{
    public class Ex41
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter The String 1:");
            string n1 = Console.ReadLine();
            Console.WriteLine("Please Enter The String 2:");
            string n2 = Console.ReadLine();
            bool result = InString(n1,n2);
            
            if(result == true)
            {
                Console.WriteLine("String 2 occurs in String 1");
            }
            else
            {
                Console.WriteLine("String 2 does not occur in String 1");
            }
        
        }
   
        public static bool InString(string s1, string s2)
        {
            int count = 0;
            string[] s1_arr = s1.ToLower().Split(' ');
            string[] s2_arr = s2.ToLower().Split(' ');
            for (int i = 0; i < s1_arr.Length; i++)
            {
                for (int j = 0; j < s2_arr.Length; j++)
                {
                    int r = s1_arr[i].CompareTo(s2_arr[j]);
                    if (r == 0)
                    {
                        count++;
                    }
                }               
            }
            if(count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
namespace CSExercises
{
    public class Ex43
    {
        public static string Hex(int i)
        {
            int quotient;
            int j = 1, temp = 0;
            char[] new_num = new char[10];
            char temp1;
            quotient = i;
            while (quotient != 0)
            {
                temp = quotient % 16;
                if (temp < 10)
                {
                    
                }
                else
                {
                    
                }
                temp1 = Convert.ToChar(temp);
                new_num[j++] = temp1;
                quotient = quotient / 16;
            }

            return new_num;

        }
        public static void Main(string[] args)
        {
            Console.Write("Please integer to change hex");
            int num = Convert.ToInt32(Console.ReadLine());
            string ans = Hex(num);
            Console.Write("The {0} of hexadecimal is {1}", num, ans);

            //for (int i = 0; i <= 100; i++)
            //    Console.WriteLine("{0:X}", i);            
        }
    }

}

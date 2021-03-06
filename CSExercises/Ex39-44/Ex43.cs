using System;

namespace CSExercises
{
    public class Ex43
    {
        public static void Main(string[] args)
        {
            Console.Write("Please integer to change hex");
            int num = Convert.ToInt32(Console.ReadLine());
            string ans = Hex(num);
            Console.WriteLine("The number of {0} of hexadecimal is {1}",num, ans);

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("The {0} of hexadecimal is {1:X}", i, i);
            }

        }
        public static string Hex(int i)
        {
            string result = "";
            int remain = i;
            if (i >= 16)
            {
                while (i / 16 > 0)
                {
                    result += (i / 16).ToString();
                    remain = i % 16;

                    i = i / 16;                   

                }
            }

            switch (remain)
            {
                case 10:
                    result += "A";
                    break;
                case 11:
                    result += "B";
                    break;
                case 12:
                    result += "C";
                    break;
                case 13:
                    result += "D";
                    break;
                case 14:
                    result += "E";
                    break;
                case 15:
                    result += "F";
                    break;
                default:
                    result += remain.ToString();
                    break;
            }
            return result;
        }
    }
}
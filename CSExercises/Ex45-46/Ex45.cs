using System;

namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            int[] coins = new int[] { 100, 50, 20, 10, 5 };
            int[] count = new int[coins.Length];

            Console.Write("Please Enter the dollar:  ");
            double dollar = Convert.ToDouble(Console.ReadLine()) * 100;
            string temp = dollar.ToString();
            string last = temp.Substring(temp.Length-1,1);
            string first = temp.Substring(0, temp.Length - 1);
            int last_num = Convert.ToInt32(last);           

            if (last_num < 5)
            {
                last_num += (5 - last_num);
            }

            string last_ans = first+Convert.ToString(last_num);
            double money = Convert.ToInt32(last_ans);

            for (int i = 0; i < coins.Length; i++)
            {
                while(money >= coins[i])
                {
                    count[i] = Convert.ToInt32(Math.Floor(money / coins[i]));
                    money = money % coins[i];
                }

            }


            for(int j = 0; j < count.Length; j++)
            {
                if (count[j] > 1)
                {
                    Console.WriteLine(coins[j]);
                }
                else if (count[j] > 0)
                {
                    Console.WriteLine(coins[j]);
                }
            }
        }
    }
}
using System;
namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            
            int[] coins = new int[] { 100, 50, 20, 10, 5 };
            int[] count = new int[coins.Length];
            Console.WriteLine("Enter the amount");
            double amount = Convert.ToDouble(Console.ReadLine()) * 100;
            string temp = amount.ToString();
            string last = temp.Substring(temp.Length - 1, 1);
            string first = temp.Substring(0, temp.Length - 1);
            int last_num = Convert.ToInt32(last);

            if (last_num < 5)
            {
                last_num += (5 - last_num);
            }

            string last_ans = first + Convert.ToString(last_num);
            double dollar = Convert.ToInt32(last_ans);

            for (int i = 0; i < coins.Length; i++)
            {

                while (dollar >= coins[i])
                {

                    count[i] = Convert.ToInt32((Math.Floor(dollar / coins[i])));

                    dollar = dollar % coins[i];
                }

            }
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] > 1)
                {
                    for (int j = 0; j < count[i]; j++)
                    {
                        Console.WriteLine("{0}c", coins[i]);
                    }
                }
                else if (count[i] > 0) Console.WriteLine("{0}c", coins[i]);
            }
        }
    }
}
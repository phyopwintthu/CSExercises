using System;
namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            int count;
            for (int i = 1; i < 1000; i++)
            {
                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}

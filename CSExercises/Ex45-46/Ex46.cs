using System;
namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            Random ran = new Random();
            int[] num = new int[10];
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            int f = 0;
            int g = 0;
            int h = 0;
            int i = 0;
            int j = 0;
           
            for (int k = 0; k < 50; k++)
            {
                int random_num = ran.Next(0, 9);
                switch(random_num){
                    case 0: num[0] = a++; break;
                    case 1: num[1] = b++; break;
                    case 2: num[2] = c++; break;
                    case 3: num[3] = d++; break;
                    case 4: num[4] = e++; break;
                    case 5: num[5] = f++; break;
                    case 6: num[6] = g++; break;
                    case 7: num[7] = h++; break;
                    case 8: num[8] = i++; break;
                    case 9: num[9] = j++; break;
                    default: Console.Write("There is no one to match.");break;
                }
            }
            Console.WriteLine("Part 1");
            Console.WriteLine("Number\tCount");
            for (int l = 0; l < 10; l++)
            {
                Console.WriteLine("{0}\t{1}",i,num[i]);
            }

            Console.WriteLine("Part 2");
            Console.WriteLine("Number");
            for (int m = 0; m < 10; m++)
            {
                Console.Write("{0}\t",i);
                int p = num[i];
                for (int n = 0; n < p; n++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
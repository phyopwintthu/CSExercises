using System;
namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int [] series= new [] {86,35,41,49,89,51,11,71,50,75,25,58,40,14,44,3,63,81,93,79};
            Console.WriteLine("The Original One\n\n");
            for (int i = 0; i < series.Length; i++)
            {
                Console.Write("{0}\t\t", series[i]);
            }
            Console.WriteLine("\n\n"); 
            for (int i = 0; i < series.Length - 1; i++)
            {
                for (int j = i + 1; j < series.Length; j++)
                {
                    if(series[j] > series[i]){

                        int temp = series[j];
                        series[j] = series[i];
                        series[i] = temp;

                    }
                }
            }
            Console.WriteLine("The Decresing One\n\n"); 
            for (int i = 0; i < series.Length; i++)
            {
               Console.Write("{0}\t\t", series[i]);
            }

        }
    }
}

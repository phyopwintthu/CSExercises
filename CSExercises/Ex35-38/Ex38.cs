using System;
namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
           string[] name = new string[] {"Jhon","Venket","Mary","Victor","Betty"};
           int[] marks = new int[] {63,29,75,82,55};
           Array.Sort(name);
            Console.WriteLine("Name in Alphabetically");
            for (int i = 0; i < name.Length; i++)
            {
               Console.WriteLine("{0}\t{1}", name[i], marks[i]);
            }

            Console.WriteLine("Marks in decending orders");
            for (int j = 0; j < marks.Length; j++)
            {
                for(int k = j+1; k < marks.Length; k++)
                {
                    if (marks[j] < marks[k]){
                        int temp = marks[k];
                        marks[k] = marks[j];
                        marks[j] = temp;
                    }
                }
                Console.WriteLine("{0}\t{1}",name[j], marks[j]);
            }

        }
    }
}

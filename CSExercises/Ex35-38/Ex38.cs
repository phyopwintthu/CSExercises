using System;
namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
           string[] name = new string[] {"Jhon","Venket","Mary","Victor","Betty"};
           int[] marks = new int[] {63,29,75,82,55};
           
            Console.WriteLine("Name in Alphabetically");
            for (int i = 0; i < name.Length; i++)
            {
                for (int j=i+1;j<name.Length;j++)
                {
                    int r = name[i].CompareTo(name[j]);
                    if (r == 1)
                    {
                        string temp = name[i];
                        name[i] = name[j];
                        name[j] = temp;

                        int temp2 = marks[i];
                        marks[i] = marks[j];
                        marks[j] = temp2;
                    }

                }
                Console.WriteLine("{0}\t{1}", name[i],marks[i]);
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

                        string temp1 = name[k];
                        name[k] = name[j];
                        name[j] = temp1;
                    }
                }
                Console.WriteLine("{0}\t{1}", name[j], marks[j]);
            }

        }
    }
}

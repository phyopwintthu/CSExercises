using System;
namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int[,] marks = new int[12,4] {{56,84,68,29}, {94,73,31,89},{41,63,36,90},{99,9,18,17},{62,3,65,75},{40,96,53,23},{81,15,27,30},{21,70,100,22},{88,50,13,12},{48,54,52,78},{64,71,67,25},{16,93,46,72}};
            Console.WriteLine("The Srudent Marks Chart\n");
            
            int total_marks;
            for (int i = 0; i < marks.GetLength(0); i++)
            {
                for (int j = 0; j < marks.GetLength(1); j++)
                {
                    Console.Write("{0}\t", marks[i,j]);
                }
                Console.Write("\n");
            }
            for (int i = 0; i < marks.GetLength(0); i++)
            {
                total_marks = 0;
                for (int j = 0; j < marks.GetLength(1); j++)
                {
                    total_marks += marks[i,j];                    
                }
                Console.Write("total marks of student {1} is {0}", total_marks,i);
                Console.Write("\n");
            }

            int grand_total=0;
            for (int i = 0; i < marks.GetLength(1); i++)
            {
                total_marks = 0;
                for (int j = 0; j < marks.GetLength(0); j++)
                {
                    total_marks += marks[j,i];
                }
                grand_total+=total_marks;
                Console.Write("Average marks of subject {1} is {0}", total_marks/marks.GetLength(1),i);
                Console.Write("\n");
            }
            int overall_avg=grand_total/marks.Length;
            Console.WriteLine("the overall average of total marks is {0}", overall_avg);           
            
            }            
        }
    }


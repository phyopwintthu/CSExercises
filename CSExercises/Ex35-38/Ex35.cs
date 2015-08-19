using System;
namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            int count = 0;

            Console.WriteLine("Please enter a phrase");
            string phrase = Console.ReadLine();
            string lower_phrase = phrase.ToLower();
            string[] vowels = new string[] {"a","e","i","o","u"};
            

            for(int i=0; i < phrase.Length; i++){
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (lower_phrase.Substring(i, 1).Equals(vowels[j]))
                    {
                        count++;
                    }
                }

            }

            int count_a = 0;
            int count_e = 0;
            int count_i = 0;
            int count_o = 0;
            int count_u = 0;

            for (int i = 0; i < phrase.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (lower_phrase.Substring(i, 1).Equals(vowels[j]))
                    {
                        switch (lower_phrase.Substring(i, 1))
                        {
                            case "a":
                                count_a++;break;
                            case "e":
                                count_e++;break;
                            case "i":
                                count_i++;break;
                            case "o":
                                count_o++;break;
                            case "u":
                                count_u++;break;
                            default: 
                                break;
                        }
                        
                    }
                }

            }
            if (count > 0 || count_a > 0 || count_e > 0 || count_i > 0 || count_o > 0 || count_u > 0)
            {
                Console.WriteLine("Total number of vowels: {0}", count);
                Console.WriteLine("Number of a: {0}",count_a);
                Console.WriteLine("Number of e: {0}",count_e);
                Console.WriteLine("Number of i: {0}",count_i);
                Console.WriteLine("Number of o: {0}",count_o);
                Console.WriteLine("Number of u: {0}",count_u);
            }
            else
            {
                Console.WriteLine("There is no vowels");
            }
            

        }
    }
}

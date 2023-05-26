using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_C_
{
    internal class Program
    {
        public static string ReverseString(string word)
        {

            char[] array = word.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        public static void OrderofWords(String words)
        {

            string[] array = words.Split(' ');
            Array.Reverse(array);
            string sentence = string.Join(" ", array);
            Console.WriteLine(sentence);

        }
        public static void ReverseWords(string words)
        {

            string[] array2 = words.Split(' ');
            Array.Reverse(array2);

            string sentence = string.Join(" ", array2);


            char[] array = sentence.ToCharArray();
            Array.Reverse(array);

            Console.WriteLine(array);
        }
        public static void Occurence(string letters)
        {
            while (letters.Length > 0)
            {

                Console.Write(letters[0] + " = ");
                int calculate = 0;
                for (int j = 0; j < letters.Length; j++)
                {
                    if (letters[0] == letters[j])
                    {
                        calculate++;

                    }
                }
                Console.WriteLine(calculate);
                letters = letters.Replace(letters[0].ToString(), string.Empty);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word");

            string word1 = Console.ReadLine();

            Console.WriteLine(ReverseString(word1));
            Console.ReadLine();

            if (word1 == ReverseString(word1))
            {
                Console.WriteLine(" palindrome");
            }
            else
            {
                Console.WriteLine("not a palindrome");
            }


            OrderofWords(word1);

            ReverseWords(word1);

            Occurence(word1);


            Console.ReadLine();
        }
    }
}


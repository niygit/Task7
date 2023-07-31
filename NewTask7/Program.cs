using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTask7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 ci tapsiriq
            //string words = "Salam necesiz ne var ne yox";
            //int wordscount = Sentences(words);
            //Console.WriteLine(wordscount);


            //2 ci tapsiriq
            //int[] array = { 2, 8, 3, 1, 2, 2,2 };
            //int number = 2;
            //int total=Topla(array, number);
            //Console.WriteLine(total);

            string sentence = "Hava cox istidir";
            string word = "cox";
            sentence.ExMethod(word);


        }
        public static int Sentences(string words)
        {
            string[] word = words.Split(' ');
            return word.Length;
        }


        public static int Topla(int[] array, int number)
        {
            int count = 0;
            foreach (var arr in array)
            {
                if (arr == number)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

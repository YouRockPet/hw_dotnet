using System;
using System.Collections.Generic;
using System.Linq;

namespace HW_06_Task2
{
    class Program
    {
        public static void swap(string a, string b)
        {
            string temp = null;
            temp = a;
            b = a;
            b = temp;
        }

        public static void deleter (List<string> list, int a)
        {
            list.RemoveAt(a);
        }
        static void Main(string[] args)
        {
            //Is the just fantasy
            string str = Console.ReadLine();
            string[] text = str.Split(" ");
            List<string> words = text.ToList();
            int maxlen = 0, minlen = 0, indexmax = 0, indexmin = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Length > maxlen)
                {
                    maxlen = text[i].Length;
                    indexmax = i;
                }
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Length < minlen)
                {
                    minlen = text[i].Length;
                    indexmin = i;
                }
            }            
                       
            swap(words[indexmin], words[indexmax]);
            deleter(words, indexmax);

            //words.RemoveAt(indexmax);

            foreach (var item in words)
            {
                Console.Write(item+" ");
            }
            //static void swap()
            //{
            //    string temp = null;
            //    temp = words[indexmin];
            //    words[indexmin] = words[indexmax];
            //    words[indexmax] = temp;
            //}
        }
    }
}
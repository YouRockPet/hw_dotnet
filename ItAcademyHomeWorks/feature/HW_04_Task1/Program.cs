using System;

namespace HW_04_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            char lit = 'z';
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine(Convert.ToChar(lit - i)); 
            }
        }
    }
}

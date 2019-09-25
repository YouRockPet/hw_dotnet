using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Int32 num1 = 0;
            byte num2 = 0;
            System.Byte num3 = 0;
            char s = '0';
            System.Char s1 = '0';
            long num4 = 0;
            Int64 num5 = 0;
            object o = 0;
            string str = "0";

            Console.WriteLine(num.GetType().ToString());
            Console.WriteLine(num1.GetType().ToString());
            Console.WriteLine(num2.GetType().ToString());
            Console.WriteLine(num3.GetType().ToString());
            Console.WriteLine(s.GetType().ToString());
            Console.WriteLine(s1.GetType().ToString());
            Console.WriteLine(num4.GetType().ToString());
            Console.WriteLine(num5.GetType().ToString());
            Console.WriteLine(o.GetType().ToString());
            Console.WriteLine(str.GetType().ToString());

            Console.ReadKey();

        }
    }
}

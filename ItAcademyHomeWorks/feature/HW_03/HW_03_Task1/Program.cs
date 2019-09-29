using System;

namespace HW_03_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите чисто 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите чисто 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Calc(num1,num2)) ;

            int Calc(int x, int y)
            {
                return x + y;
            }
        }
    }
}

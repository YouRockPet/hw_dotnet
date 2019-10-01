using System;

namespace HW_03_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите чисто 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите чисто 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите результат");
            int res = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;

            if (res == sum)
                Console.WriteLine("Right");
            else
                Console.WriteLine("Wrong");
            if (sum > res)
                Console.WriteLine("Должно быть больше");
            else if (sum < res)
                Console.WriteLine("Должно быть меньше");
           
        }
    }
}

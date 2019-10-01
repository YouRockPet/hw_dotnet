using System;

namespace WH_03_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите чисто 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите чисто 2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите оператор");
            char symbol = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите результат");
            int res = Convert.ToInt32(Console.ReadLine());
            
            int sum = num1 + num2;
            int raz = num1 - num2;

            if (symbol == '+')
            {
                if (res == sum)
                    Console.WriteLine("Right");
                else
                    Console.WriteLine("Wrong");
                if (sum > res)
                    Console.WriteLine("Должно быть больше");
                else if (sum < res)
                    Console.WriteLine("Должно быть меньше");
            }
            else if (symbol == '-')
            {
                if (res == raz)
                    Console.WriteLine("Right");
                else
                    Console.WriteLine("Wrong");
                if (raz > res)
                    Console.WriteLine("Должно быть больше");
                else if (raz < res)
                    Console.WriteLine("Должно быть меньше");
            }
            

          

        }
    }
}

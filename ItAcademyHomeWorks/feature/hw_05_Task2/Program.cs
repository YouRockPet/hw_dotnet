using System;

namespace hw_05_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[4];
            for (int i = 0; i < arr.Length-1; i++)
            {
                arr[i] = Convert.ToInt32 (Console.ReadLine());
            }

            foreach (var item in arr)
            {
                Console.Write(item+", ");
            }

            Console.WriteLine();
            Console.Write("Input number:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input position:");
            int pos = Convert.ToInt32(Console.ReadLine());

            if (pos+1 == arr.Length)
            {
                arr[pos] = num;
            }
            else
            {
                for (int i = 0; i < pos; i++)
                {
                    arr[arr.Length - 1 - i] = arr[arr.Length - 2 - i - 1];
                }

                arr[pos] = num;
            }

            foreach (var item in arr)
            {
                Console.Write(item + ", ");
            }
        }
    }
}

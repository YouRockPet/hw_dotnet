using System;

namespace hw_05_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = new int[7];
            Random rand = new Random();
            for (int i = 0; i < ar.Length; i++)
                ar[i] = rand.Next(0, 100);

            int[] ar1 = { 10, 32, 16, 74, 83, 11, 3 };

            int[] ar2 = new int[7];
                        
                for (int i = 0; i < 7; i++)
                {
                    ar2[i] = ar[i] + ar1[i];
                }

            foreach (var item in ar2)
            {
                Console.Write(item+", ");
            }
        }
    }
}

using System;

namespace hw_05_Task3
{
        class Program
        {
            static void Main(string[] args)
            {

            var watch = System.Diagnostics.Stopwatch.StartNew();

            int[] ar = new int[10000];
                Random rnd = new Random();

                for (int i = 0; i < ar.Length; i++)
                {
                    ar[i] = rnd.Next(0, 40);
                }

                foreach (var item in ar)
                {
                    Console.Write(item + ", ");
                }

                Console.WriteLine();

            //for (int i = 0; i < ar.Length / 2; i++)
            //{
            //    var temp = ar[i];
            //    ar[i] = ar[ar.Length - 1 - i];
            //    ar[ar.Length - 1 - i] = temp;
            //}
            Array.Reverse(ar);
                foreach (var item in ar)
                {
                    Console.Write(item + ", ");
                }

            Console.WriteLine();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(elapsedMs+"ms");

            // Измерения показали приблизительно равное время
        }
        }
    

}

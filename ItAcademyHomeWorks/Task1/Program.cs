using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0;
            int d = (int)a;
            int a1 = 0;
            uint b1 = (uint)a1;
            short a2 = 0;
            ulong b2 = (ulong)a2;

            int x = 0;
            long y = (long)x;
            float x1 = 0;
            double y1 = (double)x1;
            Int32 x2 = 0;
            Int64 y2 = (Int64)x2;

            int p = 0;
            object h = p; //упаковка
            int z = (int)h; //распаковка
            Console.ReadKey();

        }
    }
}

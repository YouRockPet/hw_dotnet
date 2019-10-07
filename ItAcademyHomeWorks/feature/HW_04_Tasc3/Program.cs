using System;

namespace HW_04_Tasc3
{
    class Program
    {
        static void Main(string[] args)
        {
            double withdrow = 1000;
            double StartDep = 1000;
            double coeff = 0.02;
            int month = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= month; i++)
            {
                withdrow += withdrow * coeff;
                if (i == month)
                {
                    Console.WriteLine("1 Прирост вклада через {0} месяцев будет равна {1}", i, withdrow - StartDep);
                    Console.WriteLine("2 Сумма вклада через {0} месяцев будет равна {1}", i, withdrow);
                }
            }
           


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            
            int k = 0;
            Console.WriteLine("ВВЕДИТЕ n ");
            n = Convert.ToInt32(Console.ReadLine());
            n = n * 30;
            n += 2;
            if (n <= 31)
                k = 1;
            if (n <= 28 + 31 && n > 31)
                k = 2;
            if (n <= 31 + 28 + 31 && n > 28 + 31)
                k = 3;
            if (n <= 28 + 31 + 31 + 30 && n > 31 + 28 + 31)
                k = 4;
            if (n <= 28+31+31+30+31 && n > 28 + 31 + 31 + 30)
                k = 5;
            if (n <= 28+31+31+30+31+30 && n >28+31+31+30+31)
                k = 6;
            if (n <= 28+31+31+30+31+30+31 && n >28+31+31+30+31+30)
                k = 7;
            if (n <= 28+31+31+30+31+30+31+30 && n >28+31+31+30+31+30+31)
                k = 8;
            if (n <= 28 + 31 + 31 + 30 + 31 + 30 + 31 + 30 + 31 && n >28 + 31 + 31 + 30 + 31 + 30 + 31 + 30 + 31)
                k = 9;
            if (n <= 28 + 31 + 31 + 30 + 31 + 30 + 31 + 30 + 31 + 30 && n > 28 + 31 + 31 + 30 + 31 + 30 + 31 + 30 + 31)
                k = 10;
            if (n <= 28 + 31 + 31 + 30 + 31 + 30 + 31 + 30 +31 +30 && n >28 + 31 + 31 + 30 + 31 + 30 + 31 + 30+31 +30)
                k = 11;
            if (n <= 365 && n > 28 + 31 + 31 + 30 + 31 + 30 + 31 + 30 +31 +30 && n >28 + 31 + 31 + 30 + 31 + 30 + 31 + 30+31 +30)
                k = 12;


            if (k == 1)
                Console.WriteLine("Январь");
            if (k == 2)
                Console.WriteLine("Февраль");
            if (k == 3)
                Console.WriteLine("Март");
            if (k == 4)
                Console.WriteLine("Апрель");
            if (k == 5)
                Console.WriteLine("Май");
            if (k == 6)
                Console.WriteLine("Июнь");
            if (k == 7)
                Console.WriteLine("июль");
            if (k == 8)
                Console.WriteLine("август");
            if (k == 9)
                Console.WriteLine("сентябрь");
            if (k == 10)
                Console.WriteLine("октябрь");
            if (k == 11)
                Console.WriteLine("ноябрь");
            if (k == 12)
                Console.WriteLine("декабрь");
            Console.ReadKey();
        }
    }
}

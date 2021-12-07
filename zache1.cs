using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 5;
            int n = 5;
            int[ , ] number = new int[m,n];
            Random rnd = new Random();
            int z = 0 ;
            int summ = 0;

            for(int i = 0; i < m ; i++) // первый
            {
                for (int k = 0; k < 1; k++)
                {
                    number[i, k] = rnd.Next(19, 50);
                    if (number[i, k] % 2 != 0)
                    {
                        z += 1;
                        summ += number[i, k];
                    }
                }
                
            }

            double arith = summ / z;
            Console.WriteLine("первый столбец");
            Console.WriteLine(arith);
            z = 0;
            summ = 0;
            arith = 0;
            for (int i = 0; i < m; i++) // второй
            {
                for (int k = 0; k < 1; k++)
                {
                    number[i, k] = rnd.Next(19, 50);
                    if (number[i, k] % 2 != 0)
                    {
                        z += 1;
                        summ += number[i, k];
                    }
                }

            }
            arith = summ / z;
            Console.WriteLine("второй столбец");
            Console.WriteLine(arith);
            z = 0;
            summ = 0;
            arith = 0;

            for (int i = 0; i < m; i++)  // третий
            {
                for (int k = 0; k < 1; k++)
                {
                    number[i, k] = rnd.Next(19, 50);
                    if (number[i, k] % 2 != 0)
                    {
                        z += 1;
                        summ += number[i, k];
                    }
                }

            }
            arith = summ / z;
            Console.WriteLine("третий столбец"); 
            Console.WriteLine(arith);
            z = 0;
            summ = 0;
            arith = 0;

            for (int i = 0; i < m; i++) // четвертый
            {
                for (int k = 0; k < 1; k++)
                {
                    number[i, k] = rnd.Next(19, 50);
                    if (number[i, k] % 2 != 0)
                    {
                        z += 1;
                        summ += number[i, k];
                    }
                }

            }
            arith = summ / z;
            Console.WriteLine("четвертый столбец");
            Console.WriteLine(arith);
            z = 0;
            summ = 0;
            arith = 0;

            for (int i = 0; i < m; i++) // пятый
            {
                for (int k = 0; k < 1; k++)
                {
                    number[i, k] = rnd.Next(19, 50);
                    if (number[i, k] % 2 != 0)
                    {
                        z += 1;
                        summ += number[i, k];
                    }
                }

            }
            arith = summ / z;
            Console.WriteLine("пятый столбец");
            Console.WriteLine(arith);
            Console.ReadKey();

            

        }
    }
}

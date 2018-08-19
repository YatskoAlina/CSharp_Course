using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_ForIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Task6_33();
            Console.ReadKey();
        }

        static double Enter()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        static void Task6_10()
        {
            double n = Enter();

            for(int i = 0; i <= n; i++)
            {
                if(Math.Pow(i,2) <= n)
                {
                    Console.WriteLine("{0} ", i);
                } else if(Math.Pow(i, 2) > n)
                {
                    Console.WriteLine("\nКвадрат {0} > {1}", i, n);
                    break;
                }
            }
        }

        static void Task6_11()
        {
            Console.Write("a = ");
            double a = Enter();
            double num;

            for (double i = 2; i <= 50; i++)
            {
                num = 1 + 1 / i;
                if(num >= a)
                {
                    Console.WriteLine("1 + 1/{0} = {1}  >= {2}", i, num, a);
                }
                else
                {
                    Console.WriteLine("\n1 + 1/{0} = {1}  < {2}", i, num, a);
                    break;
                }
                   


            }

        }

        static void Task6_33()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 13 == 0)
                    Console.Write("{0} ", i);
            }

            Console.WriteLine();
            int a = 0;
            while (a <= 90)
            {
                Console.Write("{0} ", a += 13);
            }
        }
    }
}

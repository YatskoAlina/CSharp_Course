using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Different
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindPow());
            Console.ReadKey();
        }

        static int Enter()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }

        static void Task5_81()
        {
            Console.Write("x = ");
            int x = Enter();
            Console.Write("y = ");
            int y = Enter();
            int mult = 0;

            for (int i = 1; i <= x; i++)
            {
                mult += y;
                Console.WriteLine("{0}:    {1} = {2}", i, y, mult);
            }

            mult = 0;
            Console.WriteLine();
            for (int i = 1; i <= y; i++)
            {
                mult += x;
                Console.WriteLine("{0}:    {1} = {2}", i, x, mult);
            }
        }

        static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
            {
                return n * Factorial(n - 1);
            }                
        }

        static double FindPow()
        {
            Console.Write("Введите число a = ");
            double a = Enter();
            Console.Write("Введите степень n = ");           
            int n = Enter();
            double pow = 1;

            for(int i = 1; i <= n; i++)
            {
                pow *= a;
                Console.WriteLine("{0} = {1}", a, pow);
            }
            
            return pow;
        }
    }
}

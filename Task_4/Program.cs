using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Task4_42();
            Console.ReadKey();
        }

        static double EnterDoubleX()
        {
            Console.Write("Enter double number\nx = ");
            double x = Convert.ToDouble(Console.ReadLine());

            return x;
        }
        
        static int EnterIntX()
        {
            Console.Write("Enter int number\nX = ");
            int x = Convert.ToInt32(Console.ReadLine());

            return x;
        }

        static int EnterIntY()
        {
            Console.Write("Enter int number\nY = ");
            int y = Convert.ToInt32(Console.ReadLine());

            return y;
        }

        static void Task4_1_2()
        {
            double x = EnterDoubleX();
            double y;

            if(x > 0)
            {
                y = Math.Sqrt(Math.Sin(x));
            }
            else
            {
                y = 1 - 2 * Math.Sin(Math.Sqrt(x));
            }
            Console.WriteLine("\nResult 4_1\ny = {0}", y);

            if (x > 0)
            {
                y = Math.Sin(Math.Sqrt(x));
            }
            else
            {
                y = 1 + 2 * Math.Sqrt(Math.Sin(x));
            }
            Console.WriteLine("\nResult 4_2\ny = {0}", y);

        }        

        static void Task4_3_4()
        {
            int x = EnterIntX();
            int y = EnterIntY();

            if (x < 4)
            {
                Console.WriteLine("\nIt`s part 1.");
            }
            else
            {
                Console.WriteLine("It`s part 2.");
            }

            if (y > 3)
            {
                Console.WriteLine("\nIt`s part 1.");
            }
            else
            {
                Console.WriteLine("It`s part 2.");
            }
        }

        static void Task4_5()
        {
            double x = EnterDoubleX();
            double y;

            if (x <= 2)
            {
                y = x;
            }
            else
            {
                y = 2;
            }
            Console.WriteLine("On 1 grafik  y = {0}", y);

            if (x <= 3)
            {
                y = -x;
            }
            else
            {
                y = -3;
            }
            Console.WriteLine("\nOn 2 grafik  y = {0}", y);
        }

        static void Task4_37()
        {
            double x = EnterDoubleX();

            if (x > -5 && x < 3)
            {
                Console.WriteLine("Interval  (–5, 3)  true");
            }
            else Console.WriteLine("Interval  (–5, 3)  false");
        }

        static void Task4_38_39()
        {
            int x = EnterIntX();
            int y = EnterIntY();
            bool temp = false;

            if(x > 3 && y > 2)
            {
                temp = true;
                Console.WriteLine("38_A = {0}", temp);
            }
            else
            {
                Console.WriteLine("38_A = {0}", temp);
            }


            if (x < -2 && y < -4)
            {
                temp = true;
                Console.WriteLine("38_B = {0}", temp);
            }
            else
            {
                Console.WriteLine("38_B = {0}", temp);
            }

            if (x < -1)
            {
                Console.WriteLine("\n39 It`s 3 part");
            }
            else if (x > -1 && x < 5)
            {
                Console.WriteLine("\n39 It`s 2 part");
            }
            else
            {
                Console.WriteLine("\n39 It`s 1 part");
            }
            
        }

        static void Task4_40_41()
        {
            double x = EnterDoubleX();
            double f;

            if (x >= -2.4 && x <= 5.7)
            {
                f = x * x;
            }
            else f = 4;

            Console.WriteLine("Task 40. F(x) = {0}", f);

            if (x >= 0.2 && x <= 0.9)
            {
                f = Math.Sin(x);
            }
            else f = 1;

            Console.WriteLine("Task 41. F(x) = {0}", f);

        }

        static void Task4_42()
        {
            double a = EnterDoubleX();
            double b = EnterDoubleX();
            double c = EnterDoubleX(); // b > a > c;
            bool res = false;

            if (a < b && b < c)
            {
                res = true;
                Console.WriteLine("42_A   a < b < c = {0}", res);
            }
            else Console.WriteLine("42_A   a < b < c = {0}", res);

            if (b > a && a > c)
            {
                res = true;
                Console.WriteLine("42_B   b > a > c = {0}", res);
            }
            else Console.WriteLine("42_B   b > a > c = {0}", res);

        }
    }
}

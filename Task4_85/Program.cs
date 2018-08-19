using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_85
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter x = ");
            //double x = Convert.ToDouble(Console.ReadLine());
            //Task4_91(x);

            Task4_92();

            Console.ReadKey();
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

        static void Task4_85_88(double x)
        {
            double y;

            // задание 85
            if (x < -1)
            {
                y = -1;
                Console.WriteLine("85   y(x) = {0}", y);
            }
            else if (x > -1)
            {
                y = x;
                Console.WriteLine("85   y(x) = {0}", y);
            }
            else
            {
                y = 1;
            }
            Console.WriteLine("85   y(x) = {0}", y);

            // задание 86
            if (x > 0)
            {
                y = 1;
            }
            else if (x < 0)
            {
                y = -1;
            }
            else
            {
                y = 0;
            }
            Console.WriteLine("\n86   z(a) = {0}", y);

            // задание 87
            if (x <= 0)
            {
                y = 0;
            }
            else if (x > 0 && x <= 1)
            {
                y = x;
            }
            else
            {
                y = x * x;
            }
            Console.WriteLine("\n87   f(x) = {0}", y);

            // задание 88
            if (x > 2)
            {
                y = 2;
            }
            else if (x > 0 && x <= 2)
            {
                y = 0;
            }
            else
            {
                y = -3 * x;
            }
            Console.WriteLine("\n88   f(y) = {0}", y);
        }

        static void Task4_89(double x)
        {
            double k, f;

            if (Math.Sin(x) < 0)
            {
                k = x * x;
            }
            else k = Math.Abs(x);

            if (k < x)
            {
                f = k * x;
            }
            else f = k + x;

            Console.WriteLine("89   F(x) = {0}", f);
        }

        static void Task4_90(double x)
        {
            double k, f;

            if (Math.Sin(x) >= 0)
            {
                k = x * x;
            }
            else k = Math.Abs(x);

            if (x < k)
            {
                f = Math.Abs(x);
            }
            else f = k * x;

            Console.WriteLine("90   F(x) = {0}", f);
        }

        static void Task4_91(double x)
        {
            double y;

            if (x <= -1)
                y = 0;
            else if (x > -1 && x <= 0)
                y = x + 1;
            else y = 1;
            Console.WriteLine("91_a   y = {0}", y);

            if (x <= -1)
                y = 1;
            else if (x > -1 && x <= 1)
                y = -x;
            else y = -1;
            Console.WriteLine("91_b   y = {0}", y);

            if (x <= -1 && x >= 1)
                y = 1;
            else if (x > -1 && x < 1)
                y = 0.5 * Math.Abs(x) + 0.5;
            Console.WriteLine("91_c   y = {0}", y);

        }

        static void Task4_92()
        {
            int x = EnterIntX();
            int y = EnterIntY();

            if (x < 1)
                Console.WriteLine("\n92     It`s part 1.");        
            else if (x >1 && x < 5)
                Console.WriteLine("\n92     It`s part 2.");
            else Console.WriteLine("\n92     It`s part 3.");

            if (y > 5)
                Console.WriteLine("\n93     It`s part 1.");
            else if (y > 2.5 && y < 5)
                Console.WriteLine("\n93     It`s part 2.");
            else Console.WriteLine("\n93    It`s part 3.");
        }
    }
}

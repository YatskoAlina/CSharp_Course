using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_68
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите угол вылетающего снаряла\nL = ");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите скорость движения снаряда\nv = ");
            double v = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ростояние на котором росположена цель\nR = ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите висоту цели\nP = ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите висоту на которой росположена цель\nH = ");
            double h = Convert.ToDouble(Console.ReadLine());

            double x, y, t, g;

            x = r;
            g = 9.8;

            t = x / (v * Math.Cos(l));
            y = v * t * Math.Sin(l) - ((g * t * t) / 2);

            if (y >= h && y <= (p + h))
            {
                Console.WriteLine("\nСнаряд поразил цель!");
            }
            else Console.WriteLine("\nСнаряд НЕ поразил цель!");

            Console.ReadKey();
        }
    }
}

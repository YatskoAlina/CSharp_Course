using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для вычисления первого уравнения:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат вычисления первого уравнения:  " + Equation1(a));

            Console.WriteLine("\nВведите число для вычисления второго уравнения:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат вычисления второго уравнения:  " + Equation2(b));

            Console.ReadLine();
        }
        
        static double Equation1(double a)
        {
            //умова першого рівняння
            return Math.Sqrt(2 * a + Math.Sin(Math.Abs(3 * a)) / 3.56);
        }

        static double Equation2(double a)
        {
            // умова другого рівняння
            return Math.Sin((3.2 + Math.Sqrt(1 + a)) / Math.Abs(5 * a));
        }              
    }
}

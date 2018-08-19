using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y = ");
            double y = Convert.ToDouble(Console.ReadLine());

            Task3_33(x, y);
            Console.ReadKey();
        }

        static void Task3_32(double x, double y)
        {
            if (x <= -2 && y >= 1)
            {
                Console.WriteLine("Точка знаходиться в областi 1");
            }
       
            if (y <= 1.5 && y >= -2)
            {
                Console.WriteLine("Точка знаходиться в областi 2");
            }
            
            if (x >= 1 && x <= 2 && y <= 4)
            {
                Console.WriteLine("Точка знаходиться в областi 3");
            }
            
            if (y >= 2 && y <= 4 && x >= 1)
            {
                Console.WriteLine("Точка знаходиться в областi 4");
            }            

            if((x >= 2 && y >= 0) || (x >= 1 && y <= -1))
            {
                Console.WriteLine("Точка знаходиться в областi 5");
            }
            
            if ((x >= 2 && y >= 1) || (x >= 2 && y <= -1.5))
            {
                Console.WriteLine("Точка знаходиться в областi 6");
            }
            
            if (x >= 1 && x <= 3 && y <= -1 && y >= -2)
            {
                Console.WriteLine("Точка знаходиться в областi 7");
            }

            if ((y >= 0.5 && y <= 1.5) || x >= 2)
            {
                Console.WriteLine("Точка знаходиться в областi 8");
            }
        }

        static void Task3_33(double x, double y)
        {
            if(x <= -1 && y <= -2)
            {
                Console.WriteLine("\nТочка знаходиться в областi 1");
            }

            if(!(y <= 1 && y >= -3))
            {
                Console.WriteLine("Точка знаходиться в областi 2");
            }

            if((y >= 1) || (y <= -3 && y >= -4))
            {
                Console.WriteLine("Точка знаходиться в областi 3");
            }

            if(x >= -1 && x <= 1.5 && y >= -0.5 && y <= 1.5)
            {
                Console.WriteLine("Точка знаходиться в областi 4");
            }

            if(x >= 1 && x <= 4 && y >= 2 && y <= 4)
            {
                Console.WriteLine("Точка знаходиться в областi 5");
            }

            if ((y >= 1 && x <= -1) || (y >= 1 && x >= 2))
            {
                Console.WriteLine("Точка знаходиться в областi 6");
            }

            if (x >= 1 && x <= 3 && y >= -3 && y <= 1)
            {
                Console.WriteLine("Точка знаходиться в областi 7");
            }

            if ((x <= 2.5 && x >= 1 && y >= -2) || y >= 1.5)
            {
                Console.WriteLine("Точка знаходиться в областi 8");
            }
        }
    }
}

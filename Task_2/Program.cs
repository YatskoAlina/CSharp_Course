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
            //створення 3х значного числа та розбиття його на цифри

            Console.WriteLine("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество цифр: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[n];

            CreateMassOfNumber(ref mass, n, num);

            Task_21(mass, num, n);

            Console.ReadLine();
        }

        static void CreateMassOfNumber(ref int[] mass, int n, int num)
        {
            //Добавление цыфр числа в массив 
            for (int i = n - 1; i >= 0; i--)
            {
                mass[i] = num % 10;
                num = num / 10;
            }
        }

        static int ConvToInt(int[] mass, int n)
        {
            // створює число з масива
            int res = 0;
            for (int i = n - 1, pow = 1; i >= 0; --i, pow *= 10)
            {
                res += mass[i] * pow;
            }
            return res;
        }

        static void Output(int[] mass, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(mass[i]);
            }
            Console.WriteLine();
        }

        static void Task2_12(int num)
        {
            //Дано трехзначное число.Найти:    
            //а) число единиц в нем;
            //б) число десятков в нем;
            //в) сумму его цифр;
            //г) произведение его цифр.

            int d1, d2, d3;
            d1 = num / 100;
            d2 = num / 10 % 10;
            d3 = num % 10;

            Console.WriteLine("\nчисло единиц - " + d3);
            Console.WriteLine("\nчисло десятков - " + d2);
            Console.WriteLine("\nсуммa цифр - " + (d1 + d2 + d3));
            Console.WriteLine("\nпроизведение цифр - " + (d1 * d2 * d3));
        }

        static void Task2_13(int[] mass, int num, int n)
        {
            //Дано трехзначное число. 
            //Найти число, полученное при прочтении его цифр справа налево.

            for (int i = 0; i < n; i++)
            {
                mass[i] = num % 10;
                num = num / 10;
                //Console.Write(mass[i] + " ");
            }
            Console.Write("\nРезультат: {0}", ConvToInt(mass, n));
        }

        static void Task2_14(int[] mass, int n)
        {
            //Дано трехзначное число.        1 2 3  2 3 1
            //В нем зачеркнули первую слева цифру и приписали ее в конце.Найти полученное число

            Console.WriteLine("\n3ачеркнули первую слева цифру и приписали ее в конце.");
            int temp = mass[0];

            for (int i = 1; i < n; i++)
            {
                mass[i - 1] = mass[i];
            }

            mass[n - 1] = temp;
            Output(mass, n);

            //В нем зачеркнули последнюю справа цифру и приписали ее в начале.Найти полученное число.
        }

        static void Task2_15(int[] mass, int n)
        {
            //В нем зачеркнули последнюю справа цифру и приписали ее в начале.Найти полученное число.
            Console.WriteLine("\n3ачеркнули последнюю справа цифру и приписали ее в начале.");

            int temp = mass[n - 1];

            for (int i = 1; i < n; i++)
            {
                mass[n - i] = mass[n - i - 1];
            }

            mass[0] = temp;
            Output(mass, n);
        }

        static void Task2_16(int[] mass, int n)
        {
            //Найти число, полученное при перестановке первой и второй цифр заданного числа.
            Console.WriteLine("\nЧисло, полученное при перестановке первой и второй цифр заданного числа.");

            int temp = mass[0];
            mass[0] = mass[1];
            mass[1] = temp;

            Output(mass, n);
        }

        static void Task2_17(int[] mass, int n)
        {
            //Найти число, полученное при перестановке второй и третьей цифр заданного числа.
            Console.WriteLine("\nЧисло, полученное при перестановке второй и третьей цифр заданного числа");

            int temp = mass[1];
            mass[1] = mass[2];
            mass[2] = temp;

            Output(mass, n);
        }

        static void Task2_18(int[] mass)
        {
            //Дано трехзначное число, в котором все цифры различны.
            //Получить шесть чисел, образованных при перестановке цифр заданного числа.

            Console.WriteLine("Number 1 = {0}{1}{2}", mass[0], mass[1], mass[2]);
            Console.WriteLine("Number 2 = {0}{1}{2}", mass[0], mass[2], mass[1]);
            Console.WriteLine("Number 3 = {0}{1}{2}", mass[1], mass[0], mass[2]);
            Console.WriteLine("Number 4 = {0}{1}{2}", mass[1], mass[2], mass[0]);
            Console.WriteLine("Number 5 = {0}{1}{2}", mass[2], mass[0], mass[1]);
            Console.WriteLine("Number 6 = {0}{1}{2}", mass[2], mass[1], mass[0]);
        }

        static void Task2_19(int[] mass, int n)
        {
            //Дано четырехзначное число.Найти:
            //а) сумму его цифр;
            //б) произведение его цифр.

            int addition = 0, multiplication = 1;
            for (int i = 0; i < n; i++)
            {
                addition += mass[i];
                multiplication *= mass[i];
            }
            Console.WriteLine("Cуммa = {0} \nПроизведение = {1}", addition, multiplication);
        }

        static void Task2_20_1(int[] mass, int n)
        {
            Console.WriteLine("\nЧисло, полученное при прочтении его цифр справа налево");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(mass[i]);
            }
        }

        static void Task2_20_2(int[] mass, int n)
        {
            Console.WriteLine("\nЧисло, образуемое при перестановке первой и второй, третьей и четвертой цифр заданного числа.");
            int temp1 = mass[0], temp2 = mass[2];
            mass[0] = mass[1];
            mass[1] = temp1;
            mass[2] = mass[3];
            mass[3] = temp2;

            //удаляет если в числе первые 0 (0123 = 123)
            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if (mass[i] != 0)
                {
                    count++;
                }

                if (count > 0)
                {
                    Console.Write(mass[i]);
                }
            }
            Console.WriteLine();
        }

        static void Task2_20_3(int[] mass)
        {
            Console.WriteLine("\nЧисло, образуемое при перестановке второй и третьей цифр заданного числа.");

            int temp = mass[1];
            mass[1] = mass[2];
            mass[2] = temp;

            Output(mass, mass.Length);
        }

        static void Task2_20_4(int[] mass, int n)
        {
            Console.WriteLine("\nЧисло, образуемое при перестановке двух первых и двух последних цифр заданного числа.");

            int temp = mass[0];
            mass[0] = mass[n - 2];
            mass[n - 2] = temp;
            temp = mass[1];
            mass[1] = mass[n - 1];
            mass[n - 1] = temp;

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                if(mass[i] != 0)
                {
                    count++;
                }

                if(count > 0)
                {
                    Console.Write(mass[i]);
                }
            }
            Console.WriteLine();
        }

        static void Task2_20_5(int num)
        {
            int d1, d2, d3, d4;
            d1 = num / 1000;
            d2 = num / 100 % 10;
            d3 = num / 10 % 10;
            d4 = num % 10; ;

            Console.WriteLine("{0} {1} {2} {3}", d1, d2, d3, d4);
            Console.WriteLine("\n{0} {1} {2} {3}", d3, d4, d1, d2);
        }

        static void Task_21(int [] mass, int num, int n)
        {
            for (int i = n - 1; i >= 0; i--)
            {
                mass[i] = num % 10;
                num = num / 10;
            }

            Console.WriteLine("\nЧисло одиниць {0}", mass[n - 1]);
            Console.WriteLine("Число десятков {0}", mass[n - 2]);
            Console.WriteLine("Число сотен {0}", mass[n - 3]);
            Console.WriteLine("Число тисяч {0}", mass[n - 4]);
        }
    }
}

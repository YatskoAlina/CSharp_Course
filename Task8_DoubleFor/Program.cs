using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_DoubleFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Task8_36();
            Console.Write(" E N D ");
            Console.ReadKey();
        }

        static void Task8_1()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write("5 ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");

            for (int i = 4; i <= 7; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0} ", i * 10 + j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }

        static void Task8_2()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("5 ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");

            for (int i = 4; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("1 ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }

        static void Task8_3()
        {
            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");

            for (int i = 4; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("{0} ", 9 - i );
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");

            for (int i = 1; i < 6; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", i * 10);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j <= 5 - i; j++)
                { 
                    Console.Write("{0} ", i * 5);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }

        static void Task8_4()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0} ", 6 + i);

                for (int j = 0; j < 4 - i; j++)
                {
                    Console.Write("{0} ", 5 - i - j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("2\n\n");
            
            for (int i = 0; i < 5; i++)
            {
                for (int j = i; j >= 0; j--)
                {
                    Console.Write("{0} ", 30 - j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5 - i; j++)
                {
                    Console.Write("{0} ", 20 - i + j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }

        static void Task8_5()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write("{0} + {1} = {2}      ", j, i, j+i);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write("{0} + {1} = {2}      ", i, j, j + i);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }

        static void Task8_7()
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write("{0} x {1} = {2}      ", j, i, j * i);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write("{0} x {1} = {2}      ", i, j, j * i);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n");
        }

        static void SimpleNum()
        {
            int[] done = new int[1000];
            int count = 0;

            for (int i = 2; i < 1000; i++)
            {
                if (Validation(done, i) == true)
                    continue;
                else
                {
                    Console.Write("{0} ", i);
                    for (int j = i + 1; j < 1000; j++)
                    {
                        if (j % i == 0 && Validation(done, j) == false)
                        {
                            done[count] = j;
                            count++;
                        } 
                    }
                }
            }            
        }

        static bool Validation(int [] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (num == arr[i])
                    return true;
            }

            return false;
        }

        static void Task8_36()
        {
            int counter = 0;
            for (int i = 1; i < 100000; i++)
            {
                for(int j  = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        counter += j;
                    }
                }

                if (counter == i)
                {
                    Console.Write("{0} ", i);
                }

                counter = 0; 
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5For
{
    class Program
    {
        static void Main(string[] args)
        {
            Task5_35();
            Console.ReadKey();
        }

        static int Enter()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }

        static int FindSum(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i;
            }
            return sum;
        }

        static int FindSumPow(int a, int b)
        {
            int sum = 0;
            for (int i = a; i <= b; i++)
            {
                sum += i * i;
            }
            return sum;
        }

        static void Task5_13()
        {
            int res;
            for (int i = 1; i <= 10; i++)
            {
                res = i * 7;
                Console.WriteLine("{0} x 7 = {1}", i, res);
            }
        }

        static void Task5_14()
        {
            int res;
            for (int i = 1; i <= 10; i++)
            {
                res = i * 9;
                Console.WriteLine("9 x {0} = {1}", i, res);
            }
        }

        static void Task5_15()
        {
            Console.Write("Введите число на которое вы хотите умножыть (1 < n < 9) \nn = ");
            int n = Enter();
            int res;

            for (int i = 1; i <= 10; i++)
            {
                res = i * n;
                Console.WriteLine("{0} x {1} = {2}", i, n, res);
            }
        }

        static void Task5_27()
        {
            int res = 0;

            for(int i = 100; i <= 500; i++)
            {
                res += i;
                //Console.WriteLine("{0} = {1}", i, res);
            }

            Console.WriteLine("\nEnter k:");
            int k = Enter();
            res = 0;
            for (int i = k; i <= 500; i++)
            {
                res += i;
                //Console.WriteLine("{0} = {1}", i, res);
            }

            Console.WriteLine("\nEnter a:");
            int a = Enter();
            Console.WriteLine("\nEnter b:");
            int b = Enter();
            res = 0;
            for (int i = a; i <= b; i++)
            {
                res += i;
                Console.WriteLine("{0}  = {1}", i, res);
            }

           
           Console.WriteLine("\nEnter b:");
            b = Enter();
            res = 0;
            for (int i = -10; i <= b; i++)
            {
                res += i;
                Console.WriteLine("{0} = {1}", i, res);
            }
        }

        static void Task5_28()
        {
            int res = 1;

            for (int i = 8; i <= 15; i++)
            {
                res *= i;
                Console.WriteLine("{0} *= {1}", i, res);
            }

            Console.WriteLine("\nEnter a:");
            int a = Enter();
            res = 1;

            for (int i = a; i <= 20; i++)
            {
                res *= i;
                Console.WriteLine("{0} *= {1}", i, res);
            }

            Console.WriteLine("\nEnter b:");
            int b = Enter();
            res = 1;
            for (int i = 1; i <= b; i++)
            {
                res *= i;
                Console.WriteLine("{0} *= {1}", i, res);
            }

            Console.WriteLine("\nEnter a:");
            a = Enter();
            Console.WriteLine("Enter b:");
            b = Enter();
            res = 1;
            for (int i = a; i <= b; i++)
            {
                res *= i;
                Console.WriteLine("{0}  *= {1}", i, res);
            }            
        }

        static void Task5_29()
        {
            int res;

            int a = 1, b = 1000;
            int sum = FindSum(a, b);
            res = sum / b;
            Console.WriteLine("Sum = {0}.   Average = {1}", sum, res);

            Console.Write("b = ");
            a = 100;
            b = Enter();
            sum = 0;
            res = 0;
            sum = FindSum(a, b);
            res = sum / b;
            Console.WriteLine("Sum = {0}.   Average = {1}", sum, res);

            Console.Write("a = ");
            a = Enter();
            b = 200;
            sum = 0;
            res = 0;
            sum = FindSum(a, b);
            res = sum / b;
            Console.WriteLine("Sum = {0}.   Average = {1}", sum, res);

            Console.Write("a = ");
            a = Enter();
            Console.Write("b = ");
            b = Enter();
            sum = 0;
            res = 0;
            sum = FindSum(a, b);
            res = sum / b;
            Console.WriteLine("Sum = {0}.   Average = {1}", sum, res);
        }

        static void Task5_30()
        {
            int res = 0;

            int a = 20, b = 40;
            for(int i = a; i <= b; i++)
            {
                res += i * i * i;
            }            
            Console.WriteLine("Sum = {0}", res);

            Console.Write("b = ");
            a = 1;
            b = Enter();           
            res = 0;
            res = FindSumPow(a, b);
            Console.WriteLine("Sum = {0}.", res);

            Console.Write("a = ");
            a = Enter();
            b = 50;
            res = 0;
            res = FindSumPow(a, b);
            Console.WriteLine("Sum = {0}.", res);

            Console.Write("a = ");
            a = Enter();
            Console.Write("b = ");
            b = Enter();
            res = 0;
            res = FindSumPow(a, b);
            Console.WriteLine("Sum = {0}.", res);
        }

        static void Task5_31()
        {
            Console.Write("n = ");
            double n = Enter();
            double a, b, sum = 0;

            for (double i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    a = Math.Pow(n, 2);
                }
                else a = n;
                b = Math.Pow(i, 2);
                sum += (a + b);
            }

            Console.WriteLine("Sum = {0}", sum);
        }

        static void Task5_32()
        {
            double sum = 0;
            int n = Enter();
            for (double i = 1; i <= n; i++)
            {
                sum += 1 / i;
                Console.WriteLine("1/{0} += {1}", i, sum);
            }
        }

        static void Task5_33()
        {
            double sum = 0;
            for (double i = 2; i <= 10; i++)
            {
                sum += i / (1 + i);
                Console.WriteLine("{0}/{2} += {1}", i, sum, (1 + i));
            }
        }

        static void Task5_34()
        {
            double count = 1.0, res = 0.0, a = 1.0;
         
            for (double i = 1; i <= 8; i++)
            {
                count = a * count;
                res += count;
                //Console.WriteLine("{0} +=  {1}", count, res);
                a = 1.0 / 3.0;
            }
            Console.WriteLine("Sum = {0}", res);
        }

        static void Task5_35()
        {
            double a = 1.0, sum = 0, n = Enter();

            for (double i = 1; i <= n; i++)
            {
                sum += 1 / i * a;
                //Console.WriteLine("1/{0} * {1} += {2}", i, a, sum);
                a *= -1;
            }
            Console.WriteLine("Sum = {0}", sum);
        }

        static void Task5_36()
        {
            double x = 2, sum = 0;

            for(double i = 1; i <= 11; i += 2)
            {
                sum += Math.Pow(x, i) / i;
                Console.WriteLine("{0} / {1} += {2}", Math.Pow(x, i), i, sum);
            }

            Console.WriteLine("Sum = {0}", sum);
        }        

        static void Task5_37()
        {
            double res = 0, b, x = 2;

            for(double i = 0; i <= 12; i++)
            {
                if (i == 0)
                {
                    b = 1;
                    Console.WriteLine("{0}", b);
                }
                else if (i % 2 != 1)
                {
                    b = -((i + 1) / (i + 2) * Math.Pow(x, i));
                    Console.WriteLine("-{0}/{1} * {2}^{3}", (i + 1), (i + 2), x, i);
                }
                else
                {
                    b = (i + 1) / (i + 2) * Math.Pow(x, i);
                    Console.WriteLine("{0}/{1} * {2}^{3}", (i + 1), (i + 2), x, i);
                } 

                res += b; 
            }
            Console.WriteLine("Res = {0}", res);
        }
    }
}

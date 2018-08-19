using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Recurent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            double n = Enter();
            Task5_68(n);

            Console.ReadLine();
        }

        static int Enter()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }

        static double Recursion(double n)
        {
            double a;

            if (n == 0)
                a = 1.0;
            else
                a = n * Recursion(n - 1) + 1 / n;

            return a;
        }

        static int Fibonachi(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            else
                return Fibonachi(n - 1) + Fibonachi(n - 2);
        }

        static int RecurFindA(double n)
        {

            if (n == 0)
            {
                return 0;
            }
            if(n == 1)
            {
                return 1;
            }
            if (n == 2)
            {
                return 2;
            }
            else
            {
                return RecurFindA(n - 1) + RecurFindA(n - 2);
            }            
        }

        static int RecurFindB(double n)
        {
            if (n == 0)
                return 0;
            if (n == 1 || n == 2)
                return 1;
            else
                return RecurFindB(n - 1) + RecurFindB(n - 2);           
        }

        static void Task5_66(double n)
        {
            for(int i = 0; i <= n; i++)
            {
                Console.WriteLine("For {0} equation = {1}", i, Recursion(i));
            }
        }       

        static void Task5_67(double n)
        {
            int f, sum = 0;
            bool res = false;
            for (int i = 0; i <= n; i++)
            {
                f = Fibonachi(i);
                sum += f;
                Console.WriteLine("For {0} = {1}", i, f);

            }

            if (sum % 2 == 0)
            {
                res = true;
                Console.WriteLine("Сумма = {1} Четное число? {0}", res, sum);
            }
            else
                Console.WriteLine("Сумма = {1} Четное число? {0}", res, sum);
        }

        static void Task5_68(double n)
        {
            double a, b, c, sum = 0.0;

            for(double i = 1; i <= n; i++)
            {
                a = RecurFindA(i);
                b = RecurFindB(i);
                c = a / b;
                sum += c;
                Console.WriteLine("Number {3} :      {0} / {1} = {2}", a, b, c, i);
            }
            Console.WriteLine("\nSum = {0}", sum);

            Console.WriteLine("Введите число с которым хотите сравнить сумму");
            double k = Enter();
            if (sum > k)
            {
                Console.WriteLine("{0} > {1}", sum, k);
            }
            else Console.WriteLine("{0} < {1}", sum, k);

        }
    }
}

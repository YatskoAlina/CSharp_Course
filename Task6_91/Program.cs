using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_91
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество цифр: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            CreateMassOfNumber(ref arr, n, num);
            SumNumbers(arr, n);
            
                
            Console.ReadKey();
        }

        static void CreateMassOfNumber(ref int[] arr, int n, int num)
        {
            //Добавление цыфр числа в массив 
            for (int i = n - 1; i >= 0; i--)
            {
                arr[i] = num % 10;
                num = num / 10;
            }
        }

        static void Output(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i]);
            }
            Console.WriteLine();
        }

        static void SumNumbers(int [] arr, int n)
        {
            int sum = 0, sumPow2 = 0, sumPow3 = 0, mult = 1;
            int pow2, pow3;

            for(int i = 0; i < n; i++)
            {
                sum += arr[i];
                mult *= arr[i];
                pow2 = arr[i] * arr[i];
                pow3 = arr[i] * pow2;
                sumPow2 += pow2;
                sumPow3 += pow3;
            }
            Console.WriteLine("Сумма = {0}", sum);
            Console.WriteLine("Среднее арифметическое = {0}", (sum / n) );
            Console.WriteLine("Произведение = {0}", mult);
            Console.WriteLine("Сумма квадратов = {0}", sumPow2);
            Console.WriteLine("Сумма кубов = {0}", sumPow3);
            Console.WriteLine("Первая цыфра = {0}", arr[0]);
            Console.WriteLine("Сумма первой и последней цыфр = {0}", arr[0] + arr[n-1]);
        }

    }
}

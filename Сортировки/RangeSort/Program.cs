using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            CreateMass(arr);
            Range(arr);

            Console.ReadKey();
        }

        static void CreateMass(int[] arr)
        {
            Random m = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = m.Next(1, 100);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }

        static void Output(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Range(int [] arr)
        {
            int min;
            for (int i = 0; i < arr.Length; i++)
            {
                min = FindMinIndex(arr, i);
                Swap(ref arr[min], ref arr[i]);
            }

            Output(arr);
        }

        static int FindMinIndex(int[] arr, int start)
        {
            int min = arr[start];
            int index = start;

            for (int i = start; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    index = i;
                }
            }

            //Console.WriteLine("{0}  {1}", min, index);
            return index;
        }
    }
}

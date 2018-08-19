using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            CreateMass(arr);
            MergeSort(arr, 0, n - 1);
            Output(arr);

            Console.ReadKey();
        }

        static void CreateMass(int[] arr)
        {
            Random m = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = m.Next(0, 10);
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
              
        static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int q = (left + right) / 2;
                MergeSort(arr, left, q);
                MergeSort(arr, q + 1, right);
                Merge(arr, left, q, right);
            }
        }

        static void Merge(int [] arr, int left, int q, int right)
        {
            int n1 = q - left + 1;
            int n2 = right - q;
            int[] l = new int[n1 + 1];
            int[] r = new int[n2 + 1];

            for (int i = 0; i < n1; i++)
            {
                l[i] = arr[left + i];
            }
            for (int i = 0; i < n2; i++)
            {
                r[i] = arr[q + 1 + i];
            }

            l[n1] = 100000;
            r[n2] = 100000;
            int j = 0, g = 0;

            for (int i = left; i <= right; i++)
            {
                if (l[j] > r[g])
                {
                    arr[i] = r[g];
                    g++;
                }
                else
                {
                    arr[i] = l[j];
                    j++;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers of elements in mass.\nn = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            CreateArr(arr);

            Console.WriteLine("Sorted Array:");
            Insertion(arr);
            OutputArr(arr);

            Console.Write("Enter key = ");
            int key = Convert.ToInt32(Console.ReadLine());

            Binary(arr, key);
            

            Console.ReadKey();
        }

        static void CreateArr(int[] arr)
        {
            Random m = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = m.Next(0, 30);
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine("\n");
        }

        static void OutputArr(int[] arr)
        {
            foreach (int m in arr)
            {
                Console.Write("{0} ", m);
            }
            Console.WriteLine();
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Insertion( int[] arr)
        {
            int key;

            for (int i = 1; i < arr.Length; i++)
            {
                key = arr[i];
                for (int j = i - 1; j >= 0 && arr[j] > key; j--)
                {
                    Swap(ref arr[j], ref arr[j + 1]);
                }
            }
        }

        static void Binary(int[] arr, int key)
        {
            int left = 0;
            int right = arr.Length - 1;
            int center, index = -1;

            while(left <= right)
            {
                center = (left + right) / 2;

                if (arr[center] > key)
                {
                    right = center - 1;
                }
                else if (arr[center] < key)
                {
                    left = center + 1;
                }
                else
                {
                    index = center;
                    break;
                } 
            }

            if (index == -1)
                Console.WriteLine("Not exist {0} ", key);            
            else
                Console.WriteLine(index);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionsSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            CreateMass(arr);
            Insertion(arr);

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

        static void Insertion(int [] arr)
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

            Output(arr);
        }

        static void Output(int [] arr)
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
    }
}

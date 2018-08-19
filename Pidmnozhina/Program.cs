using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pidmnozhina
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            
            CreateMass(arr);

            Console.Write("Enter number = ");
            int num = Convert.ToInt32(Console.ReadLine());
            Task4_10(arr, num);

            Console.ReadKey();
        }

        static void CreateMass(int[] arr)
        {
            Random m = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = m.Next(1, 10);
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

        static void Task4_10(int [] arr, int num)
        {
            List<int> set = new List<int>();
            int num2 = num;

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                    set.Add(arr[i]);
                else if (arr[i] < num)
                {
                    set.Add(arr[i]);
                    num -= arr[i];

                    for(int j = i + 1; num > 0 && j < arr.Length; j++)
                    {
                        if (arr[j] <= num)
                        {
                            set.Add(arr[j]);
                            num -= arr[j];
                        }
                    }

                    if (num == 0)
                        break;
                    else
                    {
                        num = num2;
                        set.Clear();
                    }
                }
            }

            if (set.Count == 0)
            {
                Console.Write("Sum is not exist");
                return;
            } 

            foreach(int el in set)
            {
                Console.Write("{0} ", el);
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] mass = new int[n];

            CreateMass(mass, n);
            BubbleSort(mass, n);            
            PrintMass(mass, n);

            Console.ReadLine();
        }

        static void BubbleSort(int[] mass, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (mass[j] > mass[j + 1])
                    {
                        int temp = mass[j];
                        mass[j] = mass[j + 1];
                        mass[j + 1] = temp;
                    }
                }
            }
        }

        static void CreateMass(int [] mass, int n)
        {
            Random m = new Random();
            for (int i = 0; i < n; i++)
            {
                mass[i] = m.Next(1, 100);
                Console.Write(mass[i] + " ");
            }
            Console.WriteLine("\n");
        }

        static void PrintMass(int[] mass, int n)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Bubble sort: ");
            for (int i = 0; i < n; ++i)
            {
                Console.Write(mass[i] + " ");
            }
        }        
    }    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_4
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("Enter numbers of elements in mass.\nn = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            CreateArr(arr, n);
            Task4_8(arr);
            
            Console.ReadKey();
        }

        static void CreateArr(int[] arr, int n)
        {
            Random m = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = m.Next(0, 5);
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine("\n");
        }

        static void OutputArr(int [] arr)
        {   
            foreach(int m in arr)
            {
                Console.Write("{0} ", m);
            }
            Console.WriteLine();
        }

        //Зсуває елементи масиву вправо
        static void Right(ref int [] arr, int n, int start)
        {
            int temp = arr[n - 1];
            for(int i = n - 1; i >= start; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[start] = temp;
        }

        //Зсуває елементи масиву вліво
        static void Left(ref int [] arr, int n, int end)
        {
            int temp = arr[0];
            for(int i = 0; i <= end; i++)
            {
                arr[i] = arr[i + 1];
            }
            arr[end] = temp;
        }

        //Шукає індекс максимального непарного числа
        static int MaxIndex(int [] arr, int n)
        {
            int count = 0, index = 0; 

            for(int i= 0; i < n; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    count = arr[i];
                    index = i;
                    break;
                } 
            }

            for (int i = 0; i < n; i++)
            {                
                if (arr[i] % 2 != 0 && arr[i] > count)
                {
                    count = arr[i];
                    index = i;
                }
            }

            return index;
        }

        //Мінімальний парний елемент
        static void MinParnElement(int[] arr, int n)
        {
            int element = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    element = arr[i];
                    break;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 0 && arr[i] < element)
                {
                    element = arr[i];
                }
            }

            Console.WriteLine("Min parniu Element = {0}", element);
        }

        //Шукає максимальний елемент масиву
        static int MaxElement(int[] arr, int n)
        {
            int element = 0;            

            for (int i = 0; i < n; i++)
            {
                if (arr[i] > element)
                {
                    element = arr[i];
                }
            }

            return element;
            //Console.WriteLine("Max Element = {0}", element);
        }

        //Шукає мінімальний елемент масиву
        static int MinElement(int[] arr, int n)
        {
            int element = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] < element)
                {
                    element = arr[i];
                }
            }

            return element;            
        }

        //Сума мінімального та максимального елементів масиву
        static void SumMinMaxElem(int [] arr, int n)
        {
            int min = MinElement(arr, n);
            int max = MaxElement(arr, n);

            Console.WriteLine("Min = {0}, Max = {1} \nSum = {2}", min, max, min + max);
        }

        static void Task4_2(int[] arr, int n)
        {
            CreateArr(arr, n);
            int index = MaxIndex(arr, n);
            Console.WriteLine("Max Index = {0}", MaxIndex(arr, n));

            Right(ref arr, n, index + 1);
            Console.WriteLine("\nRight 1");
            OutputArr(arr);

            Right(ref arr, n, index + 1);
            Console.WriteLine("\nRight 2");
            OutputArr(arr);

            Right(ref arr, n, index + 1);
            Console.WriteLine("\nRight 3");
            OutputArr(arr);

            Left(ref arr, n, index - 1);
            Console.WriteLine("\n\nLeft ");
            OutputArr(arr);
        }

        //Сума відємних елементів
        static void Task4_3(int[] arr, int n)
        {
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    sum += arr[i];
                }
            }

            Console.WriteLine("Sum = {0}", sum);
        }

        static void Task4_4(int[] arr, int n)
        {
            int multiplication = 1;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 != 0)
                {
                    multiplication *= arr[i];
                }
            }

            Console.WriteLine("Multiplication = {0}", multiplication);
        }

        static void Task4_10(int [] arr, int n)
        {
            Console.Write("Enter number\nN = ");
            int number = Convert.ToInt32(Console.ReadLine());
        }

        static void Task4_1(int[] arr, int n)
        {
            int count = 1;            

            for(int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if(arr[i] == arr[j])
                    {
                        count++;
                    }
                }

                if (count > 2)
                {
                    arr = DeleteElement(arr, arr[i], n - count);
                    n -= count;
                }
                count = 1;
            }

            OutputArr(arr);
        }

        static int [] DeleteElement(int [] arr, int num, int size)
        {
            int[] arr2 = new int[size];
            int count = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != num)
                {
                    arr2[count] = arr[i];
                    count++;
                }
            }
            
            return arr2;
        }
        
        static void Task4_5(int[] arr)
        {
            int sum = 0, ok = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 0)
                {
                    for(int j = i + 1; j < arr.Length; j++)
                    {
                        sum += arr[i] + arr[j];
                        if (arr[j] == 0)
                        {
                            ok = 1;
                            Console.WriteLine("Sum = {0}", sum);
                            break;
                        }
                    }
                }
                if(ok == 1)
                {
                    break;
                }
                sum = 0;
            }

            if (ok != 1)
                Console.WriteLine(0);
        }

        static void Task4_8(int[] arr)
        {
            int count = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    SwapRight(arr, count, i);
                    count++;
                }
            }

            OutputArr(arr);
        }

        static void SwapRight(int [] arr, int start, int end)
        {
            int temp = arr[end];
            for(int i = end; i > start; i--)
            {
                arr[i]= arr[i - 1];
            }
            arr[start] = temp;
        }
    }  
}

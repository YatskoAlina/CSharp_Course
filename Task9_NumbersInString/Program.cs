using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_NumbersInString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Enter();
            
            Task9_142(word);

            Console.ReadKey();
        }

        static string Enter()
        {
            return Convert.ToString(Console.ReadLine());
        }

        static int StringToInt(char i)
        {
            string num = "0123456789";

            if (i == num[0])
            {
                return 0;
            }
            else if (i == num[1])
            {
                return 1;
            }
            else if (i == num[2])
            {
                return 2;
            }
            else if (i == num[3])
            {
                return 3;
            }
            else if (i == num[4])
            {
                return 4;
            }
            else if (i == num[5])
            {
                return 5;
            }
            else if (i == num[6])
            {
                return 6;
            }
            else if (i == num[7])
            {
                return 7;
            }
            else if (i == num[8])
            {
                return 8;
            }
            else if (i == num[9])
            {
                return 9;
            }
            else return -1;
        }
        
        static void Task9_138(string w)
        {
            string numbers = "0123456789";
            bool res = false;
            for (int i = 0; i < w.Length; i++)
            {
                for(int j = 0; j < numbers.Length; j++)
                {
                    if (w[i] == numbers[j])
                        res = true;
                }                
            }

            Console.WriteLine(res);
        }

        static void Task9_139_140(string w, string num)
        {
            string res = "";
            int count = 0;

            for (int i = 0; i < w.Length; i++)
            {
                for (int j = 0; j < num.Length; j++)
                {
                    if (w[i] == num[j])
                    {
                        res += w[i];
                        count++;
                    }
                }
            }
            Console.WriteLine("{0} Count = {1}", res, count);
        }

        static void Task9_141(string w)
        {
            int sum = 0, s; 

            for (int i = 0; i < w.Length; i++)
            {
                s = StringToInt(w[i]);
                if(s > -1)
                    sum += s;
            }
            Console.WriteLine("Sum = {0}", sum);
        }

        static void Task9_141_b(string w)
        {
            int max = 0, s;

            for (int i = 0; i < w.Length; i++)
            {
                s = StringToInt(w[i]);
                if (s > -1 && s > max)
                    max = s;
            }
            Console.WriteLine("Max = {0}", max);
        }

        static void Task9_142(string w)
        {
            int max = 0, s, index = 0, count = 0;
            for (int i = 0; i < w.Length; i++)
            {
                if (w[i] == ' ')
                {
                    count++;
                }
                else break;
            }

            for (int i = 0; i < w.Length; i++)
            {
                s = StringToInt(w[i]);
                if (s > -1 && s > max)
                {
                    max = s;
                    index = i;
                }
            }
            Console.WriteLine("Max = {0} Index = {1}", max, index - count);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_Different
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Enter();
            Task9_155(word);

            Console.ReadKey();
        }

        static string Enter()
        {
            return Convert.ToString(Console.ReadLine());
        }

        static void Task9_153(string w)
        {
            int count1 = 1, count2 = 0;

            for (int i = 0; i < w.Length; i++)
            {
                for (int j = i + 1; j < w.Length; j++)
                {
                    if (w[i] == w[j])
                    {
                        count1++;
                    }
                    else break;
                }
                if (count1 > count2)
                {
                    count2 = count1;
                }
                count1 = 1;
            }
            Console.WriteLine(count2);
        }

        static void Task9_152(string w)
        {
            int count1 = 1, count2 = 0;

            for (int i = 0; i < w.Length; i++)
            {
                if (w[i] == ' ')
                {
                    for (int j = i + 1; j < w.Length; j++)
                    {
                        if (w[j] == ' ')
                        {
                            count1++;
                        }
                        else break;
                    } 
                }
                if (count1 > count2)
                {
                    count2 = count1;
                }
                count1 = 1;
            }
            Console.WriteLine(count2);
        }

        static void Task9_154(string w)
        {
            string w2 = "";

            for (int i = 0; i < w.Length; i++)
            {
                if(w2.IndexOf(w[i]) == -1)
                {
                    w2 += w[i];
                }
            }
            Console.WriteLine(w2.Length);
        }

        static void Task9_155(string w)
        {
            for (int i = 0; i < w.Length; i++)
            {
                for(int j = i + 1; j < w.Length; j++)
                {
                    if(w[i] == w[j])
                    {
                        Console.WriteLine(w[i]);
                        goto end;
                    }
                }
            }
            end:;
        }

    }
}

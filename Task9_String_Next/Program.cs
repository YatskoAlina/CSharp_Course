using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_String_Next
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Enter();
            Task9_98(word);

            Console.ReadKey();
        }

        static string Enter()
        {
            return Convert.ToString(Console.ReadLine());
        }

        static void Task9_90_91_92(string w)
        {
            string w2 = "", w3 = "", w4 = "";
            for(int i = 0; i < w.Length; i++)
            {
                if (w[i] == 'e')
                    w2 += 'i';
                else w2 += w[i];

                if (w[i] == ' ')
                    w3 += '_';
                else w3 += w[i];

                if (i % 2 == 0)
                    w4 += 'ы';
                else w4 += w[i];
            }

            Console.WriteLine(w2);
            Console.WriteLine(w3);
            Console.WriteLine(w4);
        }

        static void Task9_93(string w)
        {
            string w2 = "";         

            for (int i = 0; i < w.Length; i ++)
            {
                if ((i + 1) % 3 == 0)
                    w2 += 'a';
                else w2 += w[i]; 
            }
            Console.WriteLine(w2);
        }

        static void Task9_94_95(string w)
        {
            string w2 = "", w3 = "";
            for (int i = 0; i < w.Length - 1; i++)
            {
                if (w[i] == 'a' && w[i + 1] == 'x')
                {
                    w2 += 'y';
                    w2 += 'x';
                    i++;
                }
                else w2 += w[i];

                if (w[i] == 'd' && w[i + 1] == 'a')
                {
                    w3 += 'n';
                    w3 += 'e';
                    i++;
                }
                else w3 += w[i];
            }
            //Console.WriteLine(w2);
            Console.WriteLine("\n{0}", w3);
        }

        static void Task9_96_97(string w)
        {
            string w2 = "", w3 = "";
            for (int i = 0; i < w.Length - 2; i++)
            {
                if (w[i] == 'p' && w[i + 1] == 'r' && w[i + 2] == 'o')
                {
                    w2 += 'n';
                    w2 += 'e';
                    w2 += 't';
                    i += 2; ;
                }
                else w2 += w[i];

                if (w[i] == 'b' && w[i + 1] == 'i' && w[i + 2] == 't')
                {
                    w3 += 'r';
                    w3 += 'o';
                    w3 += 'g';
                    i += 2; ;
                }
                else w3 += w[i];
            }
            Console.WriteLine(w3);
            //Console.WriteLine(w2);
        }

        static void Task9_98(string w)
        {
            Console.WriteLine("Введите символы которие вы хотите заменить");
            string k = Enter();
            Console.WriteLine("Введите символы на которие вы хотите заменить");
            string n = Enter();

            string res = "";

            for (int i = 0; i < w.Length; i++)
            {
                if (w[i] == k[i])
                {
                    for (int j = i + 1; (j < k.Length) && (i + j < w.Length); j++)
                    {
                        i = j;
                        if (w[i + j] != k[j])
                        {
                            i -= j;
                            //goto step;
                        }
                    }
                    res += n;


                }
                else
                {
                    step:
                    res += w[i];
                }
            }

            Console.WriteLine(res);

        }

        static void Task9_99()
        {
            string s = "очепатка";
            Console.WriteLine(s);
            string s1 = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (i == 1)
                    s1 += 'п';
                else if (i == 3)
                    s1 += 'ч';
                else
                    s1 += s[i];
            }
            Console.WriteLine(s1);
        }

        static void Task9_100_101(string w)
        {
            string s1 = "", s2 = "";

            for (int i = 0; i < w.Length; i++)
            {
                if (i == 1)
                    s1 += w[4];
                else if (i == 4)
                    s1 += w[1];
                else
                    s1 += w[i];

                if (i == 2)
                    s2 += w[w.Length - 1];
                else if (i == w.Length - 1)
                    s2 += w[2];
                else
                    s2 += w[i];
            }
            Console.WriteLine(s2);
            //Console.WriteLine(s1);
        }

        static void Task9_102(string w)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            string s1 = "";

            if (n >= w.Length || m >= w.Length)
            {
                Console.WriteLine("Индекс вышел за придели масива");
            } else
            {
                for (int i = 0; i < w.Length; i++)
                {
                    if (i == n - 1)
                        s1 += w[m - 1];
                    else if (i == m - 1)
                        s1 += w[n - 1];
                    else
                        s1 += w[i];
                }
                Console.WriteLine(s1);
            }
        }

        static void Task9_103(string w)
        {
            string s1 = "";

            if (w.Length % 2 == 0)
            {
                for (int i = 0; i < w.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        s1 += w[i + 1];
                        s1 += w[i];
                    }
                }
                Console.WriteLine(s1);
            }
            else Console.WriteLine("E R R O R \nВы ввели нечетное количество символов. ");
        }

        static void Task9_104(string w)
        {
            string left = "", right = "", right2 = "";
            int n = w.Length;

            if (n % 2 == 0)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    right += w[j];
                    left += w[n - 1 - j];
                }

                for (int i = right.Length - 1; i >= 0; i--)
                {
                    right2 += right[i];
                }
                Console.WriteLine(left + right2);
            }
            else Console.WriteLine("E R R O R \nВы ввели нечетное количество символов. ");
        }
    }
}

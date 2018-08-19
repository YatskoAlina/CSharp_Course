using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Enter();
            Task9_73(word);

            Console.ReadKey();
        }

        static string Enter()
        {
            return Convert.ToString(Console.ReadLine());
        }

        static void Task9_41(string footClub)
        {
            for (int i = 0; i < footClub.Length; i++)
            {
                Console.WriteLine(footClub[i]);
            }
        }

        static void Task9_42(string word)
        {
            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }
        }

        static void Task9_43(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (i % 2 != 0)
                    Console.Write(word[i]);
            }
        }

        static void Task9_45_46_47()
        {
            string s1 = "", s2 = "", s3 = "";
            for (int i = 0; i < 5; i++)
            {
                s1 += "*";
            }
            Console.WriteLine("{0} \n", s1);

            for (int i = 0; i < 8; i++)
            {
                s2 += "_";
            }
            Console.WriteLine("{0} \n", s2);

            Console.Write("\n\nВведите длину строки n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                s3 += "#";
            }
            Console.WriteLine("{0} \n", s3);
        }

        static void Task9_44(string word)
        {
            string t = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                t += word[i];
            }

            Console.WriteLine(t);
        }

        static void Task9_48(string w)
        {
            string s1 = "", s2 = "", res;
            for (int i = 0; i < 5; i++)
            {
                s1 += "+";
            }
            for (int i = 0; i < 6; i++)
            {
                s2 += "-";
            }

            res = s1 + w + s2;
            Console.WriteLine(res);
        }

        static void Task9_49(string w)
        {
            int n = w.Length;
            string s1 = "";

            for (int i = 0; i < n; i++)
            {
                s1 += "*";
            }
            Console.WriteLine(s1 + w + s1);
        }

        static void Task9_50(string w1, string w2)
        {
            w2 = w1.Substring(0, w2.Length);
            Console.WriteLine(w2);
        }

        static void Task9_51(string w)
        {
            for (int i = 0; i < w.Length; i++)
            {
                if (w[i] == 'и')
                {
                    Console.Write("{0} ", w[i]);
                }
            }
        }

        static void Task9_53(string w)
        {
            for (int i = 2; i < w.Length; i += 3)
            {
                Console.Write("{0} ", w[i]);
            }
        }

        static void Task9_54(string w)
        {
            for (int i = 0; i < w.Length; i++)
            {
                if (w[i] == 'm')
                {
                    Console.Write("{0} ", w[i]);
                }

                if (w[i] == 'n')
                {
                    Console.Write("{0} ", w[i]);
                }
            }
        }

        static void Task9_56(string w)
        {
            for (int i = 1; i < w.Length; i++)
            {
                if (w[i] == 'n' && w[i - 1] == 'n')
                {
                    Console.Write("{0} ", w[i - 1].ToString() + w[i].ToString());
                }
            }
        }

        static void Task9_57(string w)
        {
            for (int i = 0; i < w.Length; i++)
            {
                if (w[i] == 'i' && i % 2 == 0)
                {
                    Console.WriteLine("{0} ", w[i]);
                }
            }
        }

        static void Task9_58(string w)
        {
            for (int i = 0; i < w.Length; i += 4)
            {
                Console.WriteLine("{0} ", w[i]);
                Console.WriteLine("{0} ", w[i + 1]);
            }
        }

        static void Task9_59_60(string w)
        {
            int count = 0, count2 = 0;
            for (int i = 0; i < w.Length; i++)
            {
                if (w[i] == 'o')
                {
                    Console.Write("{0} ", w[i]);
                    count++;
                }

                if (w[i] == ' ')
                {
                    count2++;
                }
            }
            Console.WriteLine("Numbers '0' = {0} ", count);
            Console.WriteLine("Numbers ' ' = {0} ", count2);
        }

        static void Task9_52_61(string w)
        {
            Console.WriteLine("Enter symbol ");
            char s = Convert.ToChar(Console.ReadLine());
            int count = 0;

            Console.WriteLine();
            for (int i = 0; i < w.Length; i++)
            {
                if (w[i] == s)
                {
                    count++;
                    Console.WriteLine("{0} ", w[i]);
                }
            }
            Console.WriteLine("Numbers '{0}' = {1}", s, count);
        }

        static void Task9_55(string w)
        {
            Console.WriteLine("Enter symbol 1 ");
            char s1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter symbol 2");
            char s2 = Convert.ToChar(Console.ReadLine());

            for (int i = 1; i < w.Length; i++)
            {
                if (w[i] == s1 || w[i] == s2)
                {
                    Console.Write("{0} ", w[i]);
                }
            }
        }

        static void Task9_62(string w)
        {
            int count = 0, x;
            for (int i = 0; i < w.Length; i++)
            {
                if (w[i] == 'a')
                {
                    count++;
                }
            }

            x = count * 100 / w.Length;
            Console.WriteLine("'a' = {0}%", x);

        }

        static void Task9_63(string w)
        {
            int count = 0, count2 = 0;
            for (int i = 0; i < w.Length; i++)
            {
                if (w[i] == '+')
                {
                    count++;
                }

                if (w[i] == '*')
                {
                    count2++;
                }
            }
            Console.WriteLine("Numbers '+' = {0} ", count);
            Console.WriteLine("Numbers '*' = {0} ", count2);
        }

        static void Task9_64(string w)
        {
            int count = 0, count1 = 0;

            for (int i = 0; i < w.Length; i++)
            {
                count = 0;
                for (int j = i + 1; j < w.Length; j++)
                {
                    if (w[j] == w[i])
                    {
                        count++;
                    }                        
                    else
                    {
                        i = j - 1;
                        break;
                    }
                }
                if (count != 0)
                {
                    count1++;
                    Console.WriteLine("{1} -- {0} ", count + 1, w[i]);
                }
            }

            Console.WriteLine("\nNumbers = {0} ", count1);
        }

        static void Task9_65(string w)
        {
            int count = 0;
            
            for (int i = 1; i < w.Length; i++)
            {
                if (w[i - 1] == 'r' && w[i] == 'o')
                {
                    count++;
                    Console.Write("{0} ", w[i - 1].ToString() + w[i].ToString());
                }
            }
            Console.WriteLine("\n{0}", count);

            Console.WriteLine("\n\nEnter symbol 1 ");
            char s1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter symbol 2");
            char s2 = Convert.ToChar(Console.ReadLine());

            count = 0;
            for (int i = 1; i < w.Length; i++)
            {
                if (w[i - 1] == s1 && w[i] == s2)
                {
                    count++;
                    Console.Write("{0}{1} ", s1, s2);
                }
            }
            Console.WriteLine("\n{0}", count);

            Console.WriteLine("\n\nEnter symbols ");
            string w2 = Enter();
            int count2 = 0;

            for (int i = 0; i < w.Length; i++)
            {
                count = 0;
                for (int j = 0; j < w2.Length; j++)
                {
                    if (w2[j] == w[i + j])
                    {
                        count++;
                    }
                    else break;
                }

                if (count == w2.Length)
                {
                    count2++;
                }
            }

            Console.WriteLine(count2);
        }

        static void Task9_65_C(string w)
        {
            Console.WriteLine("\nEnter symbols ");
            string w2 = Enter();
            int count = 0, count2 = 0;

            for (int i = 0; i < w.Length; i++)
            {
                count = 0;
                for (int j = 0; (j < w2.Length) && (i + j < w.Length); j++)
                {
                    if (w2[j] == w[i + j])
                    {
                        count++;
                    }
                    else break;
                }

                if (count == w2.Length)
                {
                    count2++;
                }
            }

            Console.WriteLine(count2);
        }

        static void Task9_66_72(string w)
        {
            int count = 0;
            for(int i = 0; i < w.Length; i++)
            {
                if (w[i] == ' ')
                    count++;                
            }

            Console.WriteLine("Numbers of words = {0}", count + 1);

            if((count + 1) > 3)
                Console.WriteLine("Numbers of words > 3");
        }

        static void Task9_68(string w)
        {
            int count = 0;
            for(int i = 0; i < w.Length; i++)
            {
                if (w[i] == '+' || w[i] == '-')
                    count++;
            }
            Console.WriteLine(count);

        }

        static void Task9_70(string w)
        {
            string s = "aeioy";
            int count = 0;

            for(int i = 0; i < w.Length; i++)
            {
                for(int j = 0; j < s.Length; j++)
                {
                    if (s[j] == w[i])
                        count++;
                }
            }
            Console.WriteLine(count);
        }

        static void Task9_71(string w)
        {
            int countM = 0, countN = 0;

            for (int i = 0; i < w.Length; i++)
            {
                if (w[i] == 'm')
                    countM++;
                if (w[i] == 'n')
                    countN++;
            }

            if (countM > countN)
                Console.WriteLine("m > n    {0} > {1}", countM, countN);
            else if (countM < countN)
                Console.WriteLine("m < n    {0} < {1}", countM, countN);
            else
                Console.WriteLine("m = n    {0} = {1}", countM, countN);

        }

        static void Task9_75(string w)
        {
            int n = 0;

            for (int i = 0; i < w.Length; i++)
            {
                if (w[i] == ',')
                {
                    n = i;
                    break;
                }
            }

            if (n != 0)
                Console.WriteLine(w.Substring(0, n));
            else
                Console.WriteLine("This sentensis have no ','");
        }

        static void Task9_76(string w)
        {
            int n = 0;

            for (int i = 0; i < w.Length; i++)
            {
                if (w[i] == 'e')
                {
                    Console.WriteLine("First E is located in {0} place", i);
                    break;
                }
            }

            for (int i = 0; i < w.Length; i++)
            {
                if (w[i] == 'e')
                {
                    n = i;
                }
            }
            Console.WriteLine("Last E is located in {0} place", n);
        }

        static void Task9_77(string w)
        {
            for (int i = 0; i < w.Length; i++)
            {
                if (w[i] == 'a')
                {
                    Console.WriteLine("First A is located in {0} place", i);
                    break;
                }
            }
        }

        static void Task9_78(string w)
        {
            string rewrite = "";

            for(int i = w.Length -1; i >= 0; i--)
            {
                rewrite += w[i];
            }

            if (w == rewrite)
                Console.WriteLine("It`s 'перевертыш'");
            else
                Console.WriteLine("It`s NOT 'перевертыш'");

        }

        static void Task9_74(string w)
        {
            int count = 1;

            for (int i = 0; i < w.Length; i++)
            {
                for (int j = i + 1; j < w.Length; j++)
                {
                    if (w[i] == w[j])
                    {
                        count++;
                    }
                }
                if(count == 5)
                {
                    Console.WriteLine(true);
                    break;
                } 

                count = 1;
            }
        }

        static void Task9_67(string w)
        {
            int count = 0;

            for (int i = 0; i + 1 < w.Length; i++)
            {
                if (w[i] != ' ' && w[i + 1] == ' ' || w[i] != ' ' && i + 1 == w.Length - 1)
                    count++;
            }

            Console.WriteLine("Numbers of words = {0}", count);
        }

        static void Task9_69(string w)
        {
            int count = 0;

            for (int i = 0; i < w.Length; i++)
            {
                if (w[i] == '.' || w[i] == '!' || w[i] == '?')
                {
                    count++;
                    for (int j = i + 1; j < w.Length; j++)
                    {
                        i = j;
                        if (w[j] != '.' && w[j] != '!' && w[j] != '?')
                        {
                            break;
                        }                        
                    }
                }


            }

            Console.WriteLine("Количество  предложений = {0}", count);
        }

        static void Task9_73(string w)
        {
            int c = w.LastIndexOf('c');
            int t = w.LastIndexOf('t');

            if (c > t)
                Console.WriteLine("'c' встречается позже чем 't' = {0}", c);
            else
                Console.WriteLine("'t' встречается позже чем 'c' = {0}", t);
        }
    }
}



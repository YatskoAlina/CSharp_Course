using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();

            int[] input = { 1, 2, 3 };

            Console.WriteLine(list.count);
            list.Add(12);
            list.Add(53);
            list.InsertRange(input, 1);
            Console.WriteLine(list.IndexOf(2));
            list.AddRange(input);

            Console.WriteLine(list.count);

            Console.ReadKey();
        }
    }
}
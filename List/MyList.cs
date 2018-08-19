using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class MyList
    {
        private int[] arr = new int[10000];
        public int count;
   
        public MyList()
        {
            count = 0;
        }

        public void Add(int num)
        {
            arr[count] = num;
            count++;
        }

        public void Clear()
        {
            count = 0;
        }

        public bool Contains(int num)
        {
            for (int i = 0; i < count; i++)
            {
                if (arr[i] == num)
                    return true;
            }

            return false;
        }

        public int IndexOf(int num)
        { 
            for (int i = 0; i < count; i++)
            {
                if (arr[i] == num)
                    return i;
            }

            return -1;
        }

        public void InsertRange(int[] colect, int index)
        {
            for (int i = 0; i < colect.Length; i++)
            {
                arr[i + index] = colect[i];
            }

            if (index + colect.Length > count)
            {
                count += index + colect.Length - count;
            }
        }

        public void AddRange(int[] colect)
        {
            for (int i = 0; i < colect.Length; i++)
            {
                arr[i + count] = colect[i];
            }

            count += colect.Length;
        }
    }
}

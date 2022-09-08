using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class IntArray : IIntArray
    {
        private int size, max, min;
        private int[] index;

        public IntArray(int size) { 
            index = new int[size];
            this.size = size;
            max = 0;
            min = 0;
        }

        public int[] Index { get => index; set => index = value; }
        public int Size { get => size; }
        public int Max { get => max; }
        public int Min { get => min; }

        
        public void FillRand(int start, int end)
        {
            Random temp = new Random();
            for (int i = 0; i < Size; i++) 
                Index[i] = temp.Next() % (end - start + 1) + start;
            UpdateProperty();
        }        
        virtual public void Print()
        {
            foreach (int item in index) { Console.Write($"{item} "); }
            Console.WriteLine(); 
        }
        public void UpdateProperty()
        {
            int maxv = index[0], minv = index[0];
            foreach (int item in index)
            {
                if (maxv < item) maxv = item;
                if (minv > item) minv = item;
            }
            max = maxv;
            min = minv;
        }
        virtual public int[] ColsAmount() => index;

        public static IntArray Create(int size) => new IntArray(size);
        public static IntArray CreateRand(int size, int minRand, int maxRand)
        {
            IntArray temp = Create(size);
            temp.FillRand(minRand, maxRand);
            return temp;
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class IntArray
    {
        public IntArray(uint size) { Index = new int[size]; this.size = size; }

        private uint size;

        public int[] Index { get; set; }
        public uint Size { get => size; }

        static public IntArray Create(uint size) => new IntArray(size);
        public void FillRand(int start, int end)
        {
            Random temp = new Random();
            for (int i = 0; i < Size; i++) Index[i] = temp.Next() % (end - start + 1) + start;
        }
        public int MaxValue()
        {
            int maxv = Index[0];
            foreach(int item in Index) { if (maxv < item) maxv = item; }
            return maxv;
        }
        public int MinValue()
        {
            int minv = Index[0];
            foreach (int item in Index) { if (minv > item) minv = item; }
            return minv;
        }
        public void Print()
        {
            foreach (int item in Index) { Console.Write($"{item} "); }
            Console.WriteLine(); 
        }
        public static IntArray CreateRand(uint size, int minRand, int maxRand)
        {
            IntArray temp = IntArray.Create(size);
            temp.FillRand(minRand, maxRand);
            return temp;
        }
    }
}

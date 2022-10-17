using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class IntArray : Matrix, IIntArray
    {
        private int size, max, min;
        private int[,] index;

        public IntArray(int size) : base(size, 1) { 
            Index = new int[1, size];
            this.size = size;
            max = 0;
            min = 0;
        }
                                 
        override public void Print()
        {
            foreach (int item in Index) { Console.Write($"{item} "); }
            Console.WriteLine(); 
        }
        
        override public int[] ColsAmount() 
        {
            int[] temp = new int[size];
            for (int i = 0; i < size; i++) temp[i] = Index[0, i];

            return temp;
        }

        public static IntArray Create(int size) => new IntArray(size);

        public static IntArray CreateRand(int size, int minRand, int maxRand)
        {
            IntArray temp = Create(size);
            temp.FillRand(minRand, maxRand);
            return temp;
        }                
    }
}

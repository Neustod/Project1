using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class Matrix : IIntArray
    {
        private int[,] index;
        private int columns, rows, max, min, size;

        public int[,] Index { get => index; set => index = value; }
        public int Size { get => size; }
        public int Max { get => max; }
        public int Min { get => min; }

        public Matrix(int columns, int rows)
        {
            Index = new int[rows, columns];
            size = columns * rows;
            this.columns = columns;
            this.rows = rows;
            max = 0;
            min = 0;
        }

        public void FillRand(int start, int end)
        {
            Random temp = new Random();
            for (int y = 0; y < rows; y++)
                for (int x = 0; x < columns; x++)
                    Index[y, x] = temp.Next() % (end - start + 1) + start;
            UpdateProperty();
        }

        virtual public void Print()
        {
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < columns; x++) Console.Write($"{index[y, x] } ");
                Console.WriteLine();
            }
        }
        virtual public int[] ColsAmount() 
        {
            int[] temp = new int[columns];
            int amount = 0;

            for (int x = 0; x < columns; x++)
            {
                for (int y = 0; y < rows; y++)
                    amount += index[y, x];

                temp[x] = amount;
                amount = 0;
            }
            return temp;
        }

        public void UpdateProperty()
        {
            int maxv = index[0, 0], minv = index[0, 0];
            foreach (int item in index)
            {
                if (maxv < item) maxv = item;
                if (minv > item) minv = item;
            }
            max = maxv;
            min = minv;
        }

        static public Matrix Create(int columns, int rows) => new Matrix(columns, rows);
        public static Matrix CreateRand(int columns, int rows, int minRand, int maxRand)
        {
            Matrix temp = Create(columns, rows);
            temp.FillRand(minRand, maxRand);
            return temp;
        }
    }
}

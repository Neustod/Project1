using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class Matrix : IntArray, IIntArray
    {
        private int[] index;
        private int columns, rows, max, min, size;

        public Matrix(int columns, int rows) : base(columns * rows)
        {
            index = Index;
            size = columns * rows;
            this.columns = columns;
            this.rows = rows;
            max = 0;
            min = 0;
        }

        override public void Print()
        {
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < columns; x++) Console.Write($"{index[x + y * rows]} ");
                Console.WriteLine();
            }
        }
        new public int[] ColsAmount() 
        {
            int[] temp = new int[columns];
            int amount = 0;

            for (int x = 0; x < columns; x++)
            {
                for (int y = 0; y < rows; y++)
                    amount += index[x + y * rows];

                temp[x] = amount;
                amount = 0;
            }
            return temp;
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

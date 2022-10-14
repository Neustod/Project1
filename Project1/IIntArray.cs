using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    interface IIntArray
    {
        public void FillRand(int start, int end);
        public int[,] Index { get; set; }
        public int Size { get; }
        public int Max { get; }
        public int Min { get; }

        public int[] ColsAmount();
        public void UpdateProperty();
        public void Print();
    }
}

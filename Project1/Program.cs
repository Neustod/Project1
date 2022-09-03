using System;

namespace Project1 
{    
    class Program 
    {      
        static void Main() 
        {
            IntArray Arr = IntArray.Create(size: 10);
            Arr.FillRand(-100, 100);

            Arr.Print();
            Console.WriteLine($"Max value = {Arr.MaxValue()}\n" +
                $"Min value = {Arr.MinValue()}");

            Console.ReadLine();
        }
    }
}

using System;

namespace Project1 
{    
    class Program 
    {      
        static void Main() 
        {
            IntArray Arr = IntArray.CreateRand(size: 10, minRand: -100, maxRand: 100); 

            Arr.Print();
            Console.WriteLine($"Max value = {Arr.MaxValue()}\n" +
                $"Min value = {Arr.MinValue()}");

            Console.ReadLine();
        }
    }
}

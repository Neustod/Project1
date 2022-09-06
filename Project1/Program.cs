using System;

namespace Project1 
{    
    class Program 
    {      
        static void Main() 
        {
            Console.Write("Enter array size>>");
            int arrsize = Convert.ToInt32(Console.ReadLine());

            IntArray Arr = IntArray.CreateRand(size: arrsize, minRand: -100, maxRand: 100); 

            Arr.Print();
            Console.Write($"Max value = {Arr.MaxValue()}\n" +
                $"Min value = {Arr.MinValue()}");

            Console.ReadLine();
        }
    }
}

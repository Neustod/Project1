using System;

namespace Project1 
{    
    class Program 
    {      
        static void Main() 
        {
            Console.Write("Enter array size >> ");
            int arrsize = Convert.ToInt32(Console.ReadLine());
                  
            IIntArray Arr = IntArray.CreateRand(size: arrsize, minRand: -100, maxRand: 100); //Task 2, 3

            Console.Write("Array: ");
            Arr.Print();
            Console.Write($"Max value = {Arr.Max}\n" +
                $"Min value = {Arr.Min}\n" +
                $"The difference between max and min = {Arr.Max - Arr.Min}\n"); //Task 1

            //------------------------------------------------------------------------ Task 4

            IIntArray Matrix1 = Matrix.CreateRand(columns: 10, rows: 10, minRand: -100, maxRand: 100);
            
            Console.WriteLine("\nMatrix: ");
            Matrix1.Print();

            Console.Write("The columns amount = ");
            foreach (int item in Matrix1.ColsAmount())
                Console.Write($"{item} ");

            Console.ReadLine();
        }
    }
}

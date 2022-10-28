using System;

namespace Project1 
{    
    partial class Program 
    {        
        static void Main() 
        {
            Console.Write("Enter array size >> ");
            int arrsize = Convert.ToInt32(Console.ReadLine());
            
            IIntArray Arr = IntArray.CreateRand(size: arrsize, minRand: -100, maxRand: 100);

            Console.Write("Array: ");
            Arr.Print();

            Console.Write($"Max value = {Arr.Max}\n" +
                $"Min value = {Arr.Min}\n" +
                $"The difference between max and min = {Arr.Max - Arr.Min}\n");

            //------------------------------------------------------------------------

            int cols = 1, rows = 1;

            Console.Write("\nCreating matrix.\nEnter amount of columns >> ");
            cols = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter amount of rows >> ");
            rows = Convert.ToInt32(Console.ReadLine());

            IIntArray Matrix1 = Matrix.CreateRand(columns: cols, rows: rows, minRand: -100, maxRand: 100);
            
            Console.WriteLine("\nMatrix: ");
            Matrix1.Print();

            Console.Write("The columns amount = ");
            foreach (int item in Matrix1.ColsAmount())
                Console.Write($"{item} ");

            Console.WriteLine("\n");

            //-------------------------------------------------------------------------

            int studentsAmount = 1;

            Console.Write("Enter the students amount >> ");
            studentsAmount = Convert.ToInt32(Console.ReadLine());

            Student[] students = new Student[studentsAmount];

            Console.WriteLine("Enter students information - first name, second name, faculty, record book num:");

            for (int i = 0; i < studentsAmount; i++)
            {
                Console.Write($"\n[Record: {i + 1}]\nFirst Name >> ");
                students[i].firstName = Console.ReadLine();

                Console.Write("Second Name >> ");
                students[i].secondName = Console.ReadLine();

                Console.Write("Faculty >> ");
                students[i].faculty = Console.ReadLine();

                Console.Write("Record book number >> ");
                students[i].recordBook = Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine("\n[Students]\n");
            foreach(Student item in students)
            {
                Console.WriteLine($"First Name: {item.firstName};\n" +
                    $"Second Name: {item.secondName};\n" +
                    $"Faculty: {item.faculty};\n" +
                    $"Record book number: {item.recordBook}\n");
            }

            string tempStr = "";
            Student search = new Student();
            int counter = 0, tempInt = 0;
            int[] conditionParams = new int[4];
            
            Console.Write("[Search for student]\n" +
                "(Enter information you search or '-1' if you dont't need it.)\n\n");
            
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Enter {(Condition)i} >> ");

                if (i % 3 != 0 && i > 0) 
                    tempStr = Console.ReadLine();
                else 
                    tempInt = Convert.ToInt32(Console.ReadLine());

                if (tempStr != "-1" && tempInt != -1)
                {
                    conditionParams[i] = 0;
                    switch (i)
                    {
                        case 0:
                            search.firstName = tempStr;
                            break;
                        case 1:
                            search.secondName = tempStr;
                            break;
                        case 2:
                            search.faculty = tempStr;
                            break;
                        case 3:
                            search.recordBook = tempInt;
                            break;
                    }
                }
                else
                    conditionParams[i] = 1;

                tempStr = "";
                tempInt = 0;
            }
                        

            Console.WriteLine("\n[Results]\n");

            foreach (Student item in students)
            {
                if ((conditionParams[0] == 0 ? item.firstName == search.firstName : true) &&
                    (conditionParams[1] == 0 ? item.secondName == search.secondName : true) &&
                    (conditionParams[2] == 0 ? item.faculty == search.faculty : true) &&
                    (conditionParams[3] == 0 ? item.recordBook == search.recordBook : true))
                {
                    counter++;
                    Console.WriteLine($"First Name: {item.firstName}; " +
                        $"Second Name: {item.secondName}; " +
                        $"Faculty: {item.faculty}; " +
                        $"Record book number: {item.recordBook};");
                }
            }

            Console.Write($"Found {counter} records.");
                    
            Console.ReadLine();
        }
    }
}

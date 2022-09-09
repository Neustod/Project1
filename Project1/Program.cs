using System;

namespace Project1 
{    
    class Program 
    {      
        struct Student
        {
            public Student(string _firstName, string _secondName, string _faculty, int _recordBook)
            {
                firstName = _firstName;
                secondName = _secondName;
                faculty = _faculty;
                recordBook = _recordBook;
            }

            public string secondName, firstName, faculty;
            public int recordBook;
        }

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

            Console.WriteLine("\n");

            //------------------------------------------------------------------------- Task 5

            Student[] students = new Student[3];

            Console.WriteLine($"Enter students information - first name, second name, faculty, record book num:");

            for (int i = 0; i < 3; i++)
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
                Console.WriteLine($"First Name: {item.firstName}; " +
                    $"Second Name: {item.secondName}; " +
                    $"Faculty: {item.faculty}; " +
                    $"Record book number: {item.recordBook}\n");
            }

            string sFirstName, sSecondName, sFaculty;
            int counter = 0;

            Console.Write("[Search for student]\n" +
                "First Name >> ");
            sFirstName = Console.ReadLine();
            Console.Write("Second Name >> ");
            sSecondName = Console.ReadLine();
            
            Console.WriteLine("\n[Results]\n");

            foreach (Student item in students)
            {
                if (item.firstName == sFirstName && item.secondName == sSecondName)
                {
                    counter++;
                    Console.WriteLine($"First Name: {item.firstName}; " +
                        $"Second Name: {item.secondName}; " +
                        $"Faculty: {item.faculty}; " +
                        $"Record book number: {item.recordBook};");
                }
            }

            Console.WriteLine($"Found {counter} records.");
                    
            Console.ReadLine();
        }
    }
}

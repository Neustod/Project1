using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    partial class Program
    {
        enum Condition
        {
            FirstName,
            SecondName,
            Faculty,
            RecordNumber
        }

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
    }
}

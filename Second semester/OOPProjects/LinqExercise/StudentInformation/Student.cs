using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInformation
{
    enum Subjects
    {
        OOP,
        MATH1,
        MATH2
    }

    class Student
    {
        public string Name { get; private set; }
        public string Faculty { get; private set; }
        public string FacultyNumber { get; private set; }
        public Dictionary<Subjects, int> Marks { get; } = new Dictionary<Subjects, int>();

        public Student(string name, string faculty, string facultyNumber)
        {
            Name = name;
            Faculty = faculty;
            FacultyNumber = facultyNumber;
        }

        public void AddMark(Subjects subject, int mark)
        {
            Marks.Add(subject, mark);
        }
    }
}

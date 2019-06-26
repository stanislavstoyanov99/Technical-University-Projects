using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var students = new List<Student>();
            var student = new Student("Иван Петров Иванов", "ФПМИ", "471218090");
            student.AddMark(Subjects.MATH1, 6);
            student.AddMark(Subjects.MATH2, 3);
            student.AddMark(Subjects.OOP, 6);
            students.Add(student);

            var student2 = new Student("Станислав Стоянов", "ФПМИ", "471218066");
            student2.AddMark(Subjects.MATH1, 3);
            student2.AddMark(Subjects.MATH2, 3);
            student2.AddMark(Subjects.OOP, 3);
            students.Add(student2);

            var OOPStudents = students.Where(x => x.Faculty == "ФПМИ")
                .Select(x => new
                {
                    studentName = x.Name,
                    studentFacultyNumber = x.FacultyNumber
                });

            foreach (var person in OOPStudents)
            {
                Console.WriteLine($"{person.studentName} -> {person.studentFacultyNumber}");
            }

            var goodOOPStudentsFacNumbers = students.Where(x => x.Marks.Any(m => (m.Key == Subjects.OOP) && (m.Value == 6)))
                .Select(x => x.FacultyNumber);
            Console.WriteLine("Excellent OOP Students' FacNumbers: ");
            foreach (var s in goodOOPStudentsFacNumbers)
            {
                Console.WriteLine(s);
            }

            var StudentNamesOnly = students.Select(s => s.Name);
            students.Remove(student2);
            foreach (var s in StudentNamesOnly)
            {
                Console.WriteLine(s);
            }

            students.Add(student2);
            foreach (var s in StudentNamesOnly)
            {
                Console.WriteLine(s);
            }
        }
    }
}

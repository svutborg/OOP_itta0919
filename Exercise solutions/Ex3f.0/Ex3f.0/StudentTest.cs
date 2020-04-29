using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3f._0
{
    // for exercise 3f.5
    static class StudentTest
    {
        // exercise 3f.6
        static Student[] students = new Student[30];
        public static void CreateStudents()
        {
            for (int i = 0; i < 30; i+=3)
            {
                students[i] = new Student($"Name{i + 1}");
                students[i + 1] = new Student($"Name{i + 2}", "University College Nordjylland");
                students[i + 2] = new Student($"Name{i + 3}", $"Student{i + 3}@uni.dk", $"12345{i + 3:000}");
            }

        }

        public static void displayStudents()
        {
            foreach (Student s in students)
            {
                s.displayStudent();
                Console.WriteLine();
            }
        }

    }
}

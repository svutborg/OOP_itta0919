using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3f._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Steffen Vutborg");
            Student s2 = new Student("Henning Thomsen");
            Console.WriteLine(Student.NumberOfStudents);

            StudentTest.CreateStudents();
            StudentTest.displayStudents();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3f._0
{
    class Student
    {
        // for exercise 3f.0
        string fullName;
        string course;
        string subject;
        string university;
        string eMail; 
        string phoneNumber;

        // for exercise 3f.1
        public Student(string fullName, string course = null, string subject = null, string university = null, string eMail = null, string phoneNumber = null)
        {
            this.fullName = fullName;
            this.course = course;
            this.subject = subject;
            this.university = university;
            this.eMail = eMail;
            this.phoneNumber = phoneNumber;

            // for exercise 3f.2
            numberOfStudents++;
        }
        public Student(string fullName): this(fullName, null, null, null, null, null) { }
        public Student(string fullName, string eMail, string phoneNumber) : this(fullName, null, null, null, eMail, phoneNumber) { }
        public Student(string fullName, string university) : this(fullName, null, university, null, null, null) { }

        // for exercise 3f.2
        static int numberOfStudents = 0;
        public static int NumberOfStudents { get => numberOfStudents; protected set => numberOfStudents = value; }

        // for exercise 3f.3
        public string displayStudent(bool silent=false)
        {
            string studentInfo = $"Full name: {fullName}\n" +
                $"Course: {course}\n" +
                $"Subject: {subject}\n" +
                $"University: {university}\n" +
                $"E-mail: {eMail}\n" +
                $"Phone number: {phoneNumber}";
            if (silent == false)
            {
                Console.WriteLine(studentInfo);
            }
            return studentInfo;
        }

        //for exercise 3f.4
        public string FullName { get => fullName; protected set => fullName = value; }
        public string Course { get => course; protected set => course = value; }
        public string Subject { get => subject; protected set => subject = value; }
        public string University { get => university; protected set => university = value; }
        public string EMail { get => eMail; protected set => eMail = value; }
        public string PhoneNumber { get => phoneNumber; protected set => phoneNumber = value; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program17
{
    //Sort student by grade
    class Student : IComparable<Student>, IDisplayable
    {
        private string name;
        private double grade;

        public static Student[] students;

        public Student(string name, double grade)
        {
            Name = name;
            Grade = grade;
        }

        public string Name { get => name; private set => name = value; }
        public double Grade { get => grade; private set => grade = value; }

        public static void AddStudent(Student student)
        {
            //Empty student list
            if (students == null)
            {
                students = new Student[1];
                students[0] = student;
            }
            //Non-empty student list
            else
            {
                //Concat with new created string array that contains the new student name 
                students = students.Concat(new Student[] { student }).ToArray();
            }
        }

        //Implement the IComparable interface:
        //CompareTo(): Compare another object (in this case, Student objects) and decide which one comes after the other in the sorted array.
        public int CompareTo(Student rightStudent)
        {
            Student leftStudent = this;

            if (rightStudent.Grade < leftStudent.Grade)
            {
                return -1;
            }
            if (rightStudent.Grade > leftStudent.Grade)
            {
                return 1;
            }

            return 0;
        }

        //Implement the IDisplayable interface:
        //Display(): Return a representation of the student.
        public string Display()
        {
            return String.Format("{0}:\t{1:N0}", Name, Grade);
        }
    }
}

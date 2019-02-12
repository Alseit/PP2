using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        class Student
        {
            public string name;
            public string ID;
            public int year;
            public Student(string name, string ID)
            {
                this.name = name;
                this.ID = ID;
            }
            public void Print()
            {
                Console.WriteLine("Student's name: " + this.name + Environment.NewLine + "Student's ID: " + this.ID + Environment.NewLine + "Student's year of study: " + (year + 1));
            }
        }
        static void Main(string[] args)
        {
            Student Alseit = new Student("Alseit", "18BD110636");
            Alseit.year = 1;
            Alseit.Print();
            Console.ReadKey();
        }
    }
}

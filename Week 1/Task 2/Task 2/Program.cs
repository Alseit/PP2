using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        // Создаем класс Student и вводим туда имя, ID и год обучения
        class Student
        {
            public string name;
            public string ID;
            public int year;
            // Создаем конструктор Student в котором содержится имя и ID 
            public Student(string name, string ID)
            {
                this.name = name;
                this.ID = ID;
            }
            // Создаем функцию которая выводит все элементы класса Student и увеличивает год обучения на 1 год
            public void Print()
            {
                Console.WriteLine("Student's name: " + this.name + Environment.NewLine + "Student's ID: " + this.ID + Environment.NewLine + "Student's year of study: " + (year + 1));
            }
        }
        static void Main(string[] args)
        {
            // Создаем переменную а типа Student
            Student a = new Student("Alseit", "18BD110636");
            a.year = 1;
            a.Print();
            Console.ReadKey();
        }
    }
}

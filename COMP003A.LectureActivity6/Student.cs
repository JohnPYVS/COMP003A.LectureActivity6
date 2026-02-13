using System;
using System.Collections.Generic;
using System.Text;

namespace COMP003A.LectureActivity6
{
    internal class Student
    {
        public string Name;
        public int Age;

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Displayinfo()
        {
            Console.WriteLine("Name: " + Name + ", Age: " + Age);
        }
    }
}

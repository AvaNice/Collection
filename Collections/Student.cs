using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Student
    {
        public int Age { get; }
        public string Name { get; }

        public Student(string name, int age)
        {
            Age = age;
            Name = name;
        }
    }
}

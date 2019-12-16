using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            return string.Equals(x.Name, y.Name);
        }

        public int GetHashCode(Student obj)
        {
            Random a = new Random();

            
           return obj.Name.GetHashCode();
            
        }
    }
}

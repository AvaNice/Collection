using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> intSet = new HashSet<int>();

            intSet.Add(1);
            intSet.Add(2);
            intSet.Add(3);
            intSet.Add(1);

            HashSet<string> stringSet = new HashSet<string>();

            stringSet.Add("Ivan");
            stringSet.Add("NeIvan");
            stringSet.Add("OldIvan");
            stringSet.Add("Ivan");
            stringSet.Add("Olha");
            
            //--------------------------------------------------------------------------------

            HashSet<int> firstIntSet = new HashSet<int>() { 1, 2, 3 };
            HashSet<int> secondIntSet = new HashSet<int>() { 2, 3, 4, 5 };

            IEnumerable<int> intersect = firstIntSet.Intersect(secondIntSet);
            IEnumerable<int> union = firstIntSet.Union(secondIntSet);
            firstIntSet.SymmetricExceptWith(secondIntSet);

            //---------------------------------------------------------------------------------

            HashSet<Student> studentsSet = new HashSet<Student>();

            studentsSet.Add(new Student("Ivan", 18));
            studentsSet.Add(new Student("NeIvan", 20));
            studentsSet.Add(new Student("OldIvan", 67));
            studentsSet.Add(new Student("Ivan", 18));

            HashSet<Student> secondStudentSet = new HashSet<Student>();

            Student ivan = new Student("Ivan", 18);
            Student neIvan = new Student("NeIvan", 20);

            secondStudentSet.Add(ivan);
            secondStudentSet.Add(neIvan);
            secondStudentSet.Add(ivan);

            //---------------------------------------------------------------------------------

            HashSet<Student> smartStudentsSet = new HashSet<Student>(new StudentComparer());

            smartStudentsSet.Add(new Student("Ivan", 18));
            smartStudentsSet.Add(new Student("NeIvan", 20));
            smartStudentsSet.Add(new Student("OldIvan", 67));
            smartStudentsSet.Add(new Student("Ivan", 18));


            //Console.WriteLine(firstIntSet[0]);

            Console.ReadKey();
        }
    }
}

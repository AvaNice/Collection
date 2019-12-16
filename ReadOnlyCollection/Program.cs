using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3 };

            list.Add(4);

            list.Remove(2);

            ReadOnlyCollection<int> readOnly = new ReadOnlyCollection<int>(list);

            ICollection<int> collection = readOnly;

            Console.WriteLine(readOnly.Count);

            try
            {
                collection.Add(2); //

                Console.WriteLine("add");
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
            }

            list.Add(5); //изменение

            Console.WriteLine(readOnly.Count);

            List<int> list2 = readOnly.ToList<int>();

            list2.Add(6);

            Console.WriteLine(readOnly.Count);

            //---------------------------------------------------------------------------------

            IReadOnlyCollection<int> iReadOnlyCollection = list;

            int count = iReadOnlyCollection.Count();

            IReadOnlyList<int> iReadOnlyList = list;

            int item = iReadOnlyList[0];

            List<int> list3 = (List<int>)iReadOnlyCollection;

            Console.WriteLine(iReadOnlyCollection.Count);

            list3.Add(7);

            Console.WriteLine(iReadOnlyCollection.Count);

            //----------------------------------------------------------------------------------

            Dictionary<int, string>  dictionary = new Dictionary<int, string>() { { 1, "1" }, { 2, "2" } };

            dictionary.Add(3, "3");

            IReadOnlyDictionary<int, string> readOlnyDictionary = dictionary;

            string value = readOlnyDictionary[2];

            Console.ReadKey();
        }
    }
}

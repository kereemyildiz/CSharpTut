using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTut
{
    class ArrayListUsage
    {
        static void ArrayListMain(string[] args)
        {
            #region ArrayList Code
            ArrayList aList = new ArrayList();
            aList.Add("Bob");
            aList.Add(40);
            Console.WriteLine("Count: {0}", aList.Count);
            Console.WriteLine("Capacity: {0}", aList.Capacity);

            ArrayList aList2 = new ArrayList();
            aList2.AddRange(new object[] { "Mike", "Sally", "Egg" });
            aList.AddRange(aList2);
            aList2.Sort();
            aList2.Reverse();
            aList2.Insert(1, "Turkey");
            ArrayList range = aList2.GetRange(0, 2);

            foreach (object o in aList2)
            {
                Console.WriteLine(o);
            }

            //aList2.RemoveAt(0);
            //aList2.RemoveRange(0, 2);
            Console.WriteLine("Turkey Index : {0}", aList2.IndexOf("Turkey", 0)); // 0 for starting to search with first index 
            string[] myArray = (string[])aList2.ToArray(typeof(string));
            string[] customers = { "Bob", "Sally" };
            ArrayList custArrayList = new ArrayList();
            custArrayList.AddRange(customers);
            foreach (string s in custArrayList)
            {
                Console.WriteLine(s);
            }

            #endregion

            Console.ReadLine();
        }
    }
}

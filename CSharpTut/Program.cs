using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTut
{
    class Program
    {
        delegate double doubleIt(double val);
        public static int x = 0;
        static void Main(string[] args)
        {
            doubleIt dblIt = x => x * 2;
            Console.WriteLine($"5 * 2 = {dblIt(5)}");

            List<int> numList = new List<int> {1, 9, 2, 6, 3};
            var evenList = numList.Where(a => a % 2 == 0).ToList();
            foreach(var item in evenList)
            {
                Console.WriteLine(item);
            }

            var rangeList = numList.Where(x => (x > 2) && (x < 9)).ToList();

            foreach (var item in rangeList)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
    }
}

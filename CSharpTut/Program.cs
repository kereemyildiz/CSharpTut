using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTut
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior maximus = new Warrior("Maximus", 1000, 120, 40); // name,health,attack value, block value
            Warrior bob = new Warrior("Bob", 1000, 120, 40);
            Battle.StartFight(maximus, bob);
            Console.ReadLine();
        }
    }
}

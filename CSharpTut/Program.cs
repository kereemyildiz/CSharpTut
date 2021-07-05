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
            Animal cat = new Animal();

            cat.SetName("Whiskers");
            cat.Sound = "Meow";

            Console.WriteLine("The cat is named {0} and says {1}", cat.GetName(), cat.Sound);

            cat.Owner = "Kerem";

            Console.WriteLine("{0} owner is {1}", cat.GetName(), cat.Owner);
            Console.WriteLine("{0} shelter id is {1}", cat.GetName(), cat.idNum);
            Console.WriteLine("# of Animals {0}", Animal.NumOfAnimals);


            Console.ReadLine();

        }
    }
}

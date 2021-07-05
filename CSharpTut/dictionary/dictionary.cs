using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTut
{
    class DictionaryUsage
    {
        static void DictionaryMain(string[] args)
        {
            Dictionary<string, string> superheroes = new Dictionary<string, string>();
            superheroes.Add("Clark Kent", "Superman");
            superheroes.Add("Bruce Wayne", "Batman");
            superheroes.Add("Robert Downey Jr.", "Iron Man");

            superheroes.Remove("Bruce Wayne");
            Console.WriteLine("Count : {0}", superheroes.Count);
            Console.WriteLine("Clark Kent : {0}", superheroes.ContainsKey("Clark Kent"));

            superheroes.TryGetValue("Clark Kent", out string test);
            Console.WriteLine($"Clark Kent : {test}");

            foreach (KeyValuePair<string, string> item in superheroes)
            {
                Console.WriteLine("{0}: {1}", item.Key, item.Value);
            }
            superheroes.Clear();
            Console.ReadLine();
        }
    }
}

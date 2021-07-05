using System;

namespace CSharpTut
{
    class Dog : Animal
    {
        public string Sound2 { get; set; } = "Grrr";
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }
        public Dog (string name = "No Name",
            string sound = "No Sound",
            string sound2 = "No Sound 2")
            :base(name,sound)
        {
            Console.WriteLine("Dog constructor");
            Sound2 = sound2;
        }
        
    }
}

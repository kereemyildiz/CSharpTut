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
            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meow"
            };

            Console.WriteLine("******");

            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2 = "Grrrr"
            };

            grover.Sound = "Wooooof";
            whiskers.Name = "Cat";

            whiskers.MakeSound();
            grover.MakeSound();

            whiskers.SetAnimalIDInfo(12345, "Ahmet Yilmaz");
            grover.SetAnimalIDInfo(14, "Mehmet Atar");
            whiskers.GetAnimalIDInfo();
            grover.GetAnimalIDInfo();

            Animal.AnimalHealth getHealth = new Animal.AnimalHealth();
            Console.WriteLine("Is my animal healthy : {0}",getHealth.HealtyWeight(11,46));

            Animal monkey = new Animal()
            {
                Name = "Happy",
                Sound = "Eeee"
            };

            Animal spot = new Dog()
            {
                Name = "Spot",
                Sound = "Woofff",
                Sound2 = "Geeerrrr"
            };

            monkey.MakeSound();
            //spot.MakeSound(); // calls base method's function. Thus, polymorphism is necessary
            spot.MakeSound();
            Console.ReadLine();
        }
    }
}

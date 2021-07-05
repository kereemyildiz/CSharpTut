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
            Shape[] shapes = {new Circle(5),
            new Rectangle(4,5)};

            foreach (Shape s in shapes)
            {
                s.GetInfo();
                Console.WriteLine($"{s.Name} Area : {s.Area()}");
                Circle testCirc = s as Circle;
                if (testCirc == null)
                {
                    Console.WriteLine("This is not a circle");
                }
                if (s is Circle)
                {
                    Console.WriteLine("This is not a Rectangle");
                }

                object circ1 = new Circle(4);
                Circle circ2 = (Circle)circ1;
                Console.WriteLine("The {0} Area is {1:f2}", circ2.Name, circ2.Area());
                Console.WriteLine();

            }
            Console.ReadLine();
        }  
    }
}

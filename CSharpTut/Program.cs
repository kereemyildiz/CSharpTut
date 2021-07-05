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
            Vehicle buick = new Vehicle("Buick", 4, 160);
            if (buick is IDrivable)
            {
                buick.Move();
                buick.Stop();
            }
            else
            {
                Console.WriteLine("The {0} cant be driven", buick.Brand);
            }

            IElectornicDevice TV = TVRemote.GetDevice();
            PowerButton powBut = new PowerButton(TV);
            powBut.Execute();
            powBut.Undo();

            Console.ReadLine();
        }  
    }
}

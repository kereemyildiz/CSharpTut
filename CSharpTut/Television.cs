using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTut
{
    class Television : IElectornicDevice
    {
        public int Volume { get; set; }

        public void Off()
        {
            Console.WriteLine("The TV is Off");
            Volume = 0;
        }

        public void On()
        {
            Console.WriteLine("The TV is On");
        }

        public void VolumeDown()
        {
            if (Volume != 0) Volume--;
            Console.WriteLine("Volume is {0}", Volume);
        }

        public void VolumeUp()
        {
            if (Volume != 100) Volume++;
            Console.WriteLine("Volume is {0}", Volume);
        }
    }
}

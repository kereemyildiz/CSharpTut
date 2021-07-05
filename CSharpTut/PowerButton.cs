using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTut
{
    class PowerButton : ICommand
    {
        IElectornicDevice device;
        public PowerButton(IElectornicDevice device)
        {
            this.device = device;
        }
        public void Execute()
        {
            device.On();
        }

        public void Undo()
        {
            device.Off();
        }
    }
}

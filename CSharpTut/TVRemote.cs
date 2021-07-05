using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTut
{
    class TVRemote
    {
        public static IElectornicDevice GetDevice()
        {
            return new Television();
        }
    }
}

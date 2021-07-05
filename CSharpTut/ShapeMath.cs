using System;

namespace CSharpTut
{
    public static class ShapeMath
    {
        public static double GetArea(string shape = "",
            double length1 = 0,
            double length2 = 0)
        {
            if (String.Equals("Rectangle", shape,
                StringComparison.OrdinalIgnoreCase))
            {
                return length1 * length2;
            }
            else if (String.Equals("Triangle", shape,
              StringComparison.OrdinalIgnoreCase))
            {
                return length1 * length2 / 2;
            }
            return -1;
        }
    }
}

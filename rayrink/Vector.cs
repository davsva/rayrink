using System;
using System.Collections.Generic;
using System.Text;

namespace rayrink
{
    public class Vector : Tuple
    {
        public Vector(float x, float y, float z) : base(x, y, z, 0.0f)
        {
        }
    }
}

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

        public Vector(float x, float y, float z, float w) : base(x, y, z, w)
        {
        }

        public float Magnitude()
        {
            return (float)Math.Sqrt((X * X) + (Y * Y) + (Z * Z) + (W * W));
        }

        public Vector Normalize()
        {
            float magnitude = Magnitude();
            return new Vector(X / magnitude, Y / magnitude, Z / magnitude, W / magnitude);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace rayrink
{
    public class Tuple
    {
        private float x, y, z, w;

        public Tuple(float x, float y, float z, float w)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.W = w;
        }

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
        public float Z { get => z; set => z = value; }
        public float W { get => w; set => w = value; }

        public bool IsVector()
        {
            if (MathHelper.IsEqual(this.w, 0.0f))
                return true;
            return false;
        }

        public bool IsPoint()
        {
            if (MathHelper.IsEqual(this.w, 1.0f))
                return true;
            return false;
        }

        public override bool Equals(object obj)
        {
            var tuple = obj as Tuple;
            return tuple != null &&
                MathHelper.IsEqual(x, tuple.x) &&
                MathHelper.IsEqual(y, tuple.y) &&
                MathHelper.IsEqual(z, tuple.z) &&
                MathHelper.IsEqual(w, tuple.w);
        }

        public static Tuple operator +(Tuple a, Tuple b)
        {
            return new Tuple(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
        }

        public static Tuple operator -(Tuple a, Tuple b)
        {
            return new Tuple(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        }
    }
}

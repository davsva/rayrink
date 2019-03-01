using System;
using System.Collections.Generic;
using System.Text;

namespace rayrink
{
    public class MathHelper
    {
        private static readonly float epsilon = 0.00001f;

        public static bool IsEqual(float a, float b)
        {
            return Math.Abs(a - b) < epsilon ? true : false;
        }
    }
}

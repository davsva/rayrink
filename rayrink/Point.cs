﻿using System;
using System.Collections.Generic;
using System.Text;

namespace rayrink
{
    public class Point : Tuple
    {
        public Point(float x, float y, float z) : base(x, y, z, 1.0f)
        {
        }
    }
}

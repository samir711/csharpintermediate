﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpIntermediate
{
    public class Canvas
    {
        public void DrawShapes(List<Shape1> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();                
            }
        }

    }
}

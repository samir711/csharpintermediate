﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpIntermediate
{
    public class Rectangle : Shape1
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Rectangle");
        }
    }

    public class Triangle : Shape1
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a triangle");
        }
    }

}

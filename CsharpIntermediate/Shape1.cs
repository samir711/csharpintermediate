using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpIntermediate
{
    public  abstract class Shape1
    {
        public int Width { get; set; }
        public int Height { get; set; }
        //public Position Position { get; set; }
        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Copy shape into clipboard.");
        }
       

    }
}

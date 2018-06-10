using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpIntermediate
{
    public class PresentationObject
    {
        public int width { get; set; }
        public int height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied to Clipboard");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated.");
        }
    }
}

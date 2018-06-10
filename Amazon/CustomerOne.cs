using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpIntermediate
{
    public class CustomerTwo
    {
         public int Id { get; set; }

        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new RateCalculatore();
            //calculator.Calculate(this);
        }

    }
}

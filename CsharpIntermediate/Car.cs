using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpIntermediate
{
   public class Car : Vehicle
    {

       public Car(string registrationNumber):base(registrationNumber)
       {
           Console.WriteLine("CAR IS BEING INTIALIZED . {0}",registrationNumber);
       }
     
    }
}

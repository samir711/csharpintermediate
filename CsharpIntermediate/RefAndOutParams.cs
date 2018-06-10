using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpIntermediate
{
    public class RefAndOutParams
    {
        
        public void ValExample(int a)
        {
           a += 2;
        }

        
         public void RefExample(ref int a)
        {
            a += 2;
        }
         //var valueofA = new RefAndOutParams();
        //valueofA.ValExample(i);
        //Console.WriteLine("The value of i after : ValExample is : " +  i);
        //valueofA.RefExample(ref i);
        //Console.WriteLine("The value of i after : Ref Example is  : " + i );

        //try
        //    {
        //        var num = int.Parse("abc");
        //    }
        //    catch (Exception)
        //    {
                
        //        Console.WriteLine("Conversion failed");
        //    }

            // OR

            //int number;
            //var result = int.TryParse("Abc", out number);
            //if (result) Console.WriteLine(number);
            //else Console.WriteLine("Conversion failed");
         static void UseParams()
         {
             var cal = new Calculator();
             Console.WriteLine(cal.Add(1, 2));
             Console.WriteLine(cal.Add(1, 2, 3));
         }

    }
}

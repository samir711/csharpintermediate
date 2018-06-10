using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpIntermediate
{
   public class Point
    {
       public int X;
       public int Y;

       public Point(int x, int y)
       {
           this.X = x;
           this.Y = y;

       }

       public void Move(int x, int y)
       {
           this.X = x;
           this.Y = y;
       }

       public void Move(Point newLocation)
       {
           Move(newLocation.X, newLocation.Y);
       }

       static void UsePoints()
       {
           try
           {
               var point = new Point(20, 30);

               point.Move(null);

               Console.WriteLine("Point is at {0}, {1}", point.X, point.Y); ;

               point.Move(100, 200);

               Console.WriteLine("Point is at {0}, {1}", point.X, point.Y); ;
           }
           catch (Exception)
           {

               Console.WriteLine("An unexpeceted error occured.");
           }
       }

    }
}

using CsharpIntermediate.Testability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpIntermediate
{

   
    class Program
    {
        static void Main(string[] args)
        {

            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);
            //var circle = new Circle();
            //circle.Draw();
            //var rectangle = new Rectangle();
            //rectangle.Draw();
            //var shapes = new List<Shape1>();

            //shapes.Add(new Circle());
            //shapes.Add(new Rectangle());
            //shapes.Add(new Triangle());

            //var canvas = new Canvas();
            //canvas.DrawShapes(shapes);

            //Text1 text1 = new Text1();
            //Shape shape = text1;
            //text1.Width = 200;
            //text1.Width = 100;
            //Console.WriteLine(text1.Width);


           // var car = new Car("xyz");
            //var customer = new Amazon.CustomerOne();
            //var ratecal = new Amazon.RateCalculatore();
           

   

            

               

        }

     
        
    }
}

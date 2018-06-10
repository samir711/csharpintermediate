using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsharpIntermediate.Testability;

namespace Testability.UnitTests
{
    [TestClass]
    public class OrderProcessorTest
    {
        [TestMethod]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
               Shipment = new Shipment()
            };
        }
    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpIntermediate.Testability
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalcuator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalcuator = shippingCalculator;

        }

        public void Process(Order order)
        {
            if (order.isShipped)
            {
                throw new InvalidOperationException("This order is already processed.");
            }

            order.Shipment = new order.Shipment 
            {
                Cost = _shippingCalcuator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}

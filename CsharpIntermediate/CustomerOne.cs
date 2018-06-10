using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpIntermediate
{
    public class CustomerOne
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(true);
            if (rating == 0) 
            {
                Console.WriteLine("Promoted to Level 1");
            }
            else
            {
                Console.WriteLine("promtoted to Level 2");
            }
        }

        public int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}

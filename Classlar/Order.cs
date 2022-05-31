using System;
using System.Collections.Generic;
using System.Text;

namespace Classlar
{
    public class Order
    {
        public Product Product { get; set; }
        public Category Category { get; set; }
        public Customer Customer { get; set; }
    }
}

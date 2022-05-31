using System;
using System.Collections.Generic;
using System.Text;

namespace Classlar
{
    public class Delivery: Order
    {
        public Employee Employee{ get; set; }
        public Payment Payment { get; set; }
    }
}

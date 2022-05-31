using System;
using System.Collections.Generic;
using System.Text;

namespace Classlar
{
    public class Payment
    {
        public Customer Customer { get; set; }
        public Person Person { get; set; }
        public Employee Employee { get; set; }
        public decimal Balance { get; set; }
    }
}

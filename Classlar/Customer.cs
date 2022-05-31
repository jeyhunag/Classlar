using System;
using System.Collections.Generic;
using System.Text;

namespace Classlar
{
    public class Customer : Person
    {
        public string CustomerType { get; set; }
        public string CustomerNumber { get; set; }
        public Payment Payment { get; set; }
    }
}

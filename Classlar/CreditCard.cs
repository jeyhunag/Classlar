using System;
using System.Collections.Generic;
using System.Text;

namespace Classlar
{
    class CreditCard: Payment
    {
        public int CreditCardNumber { get; set; }
        public decimal CreditCardType { get; set; }
        public Sebet Sebet { get; set; }
        public Order Order { get; set; }
    }
}

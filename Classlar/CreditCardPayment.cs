using System;
using System.Collections.Generic;
using System.Text;

namespace Classlar
{
    class CreditCardPayment: Payment
    {
        public int CreditCardNumber { get; set; }
        public decimal CreditCardType { get; set; }
        public Basket Sebet { get; set; }
        public Order Order { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Classlar
{
    public class Selles: Product
    {
        public string EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public string ProductID { get; set; }
        public Product Product { get; set; }
        public string ProductCategoryID { get; set; }
        public Category ProductCategory { get; set; }
        public int salany { get; set; }


    }
}

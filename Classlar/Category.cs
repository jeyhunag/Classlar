using System;
using System.Collections.Generic;
using System.Text;

namespace Classlar
{
    public class Category
    {
        public string CategoryType { get; set; }
        public int CategoryHistory { get; set; }
        public int ProductID { get; set; }
        public  Product Product { get; set; }

    }
}

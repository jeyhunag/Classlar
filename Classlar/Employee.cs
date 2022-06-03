using System;
using System.Collections.Generic;
using System.Text;

namespace Classlar
{
    public class Employee: Person
    {
        public int EmID { get; set; }
        public float Salany { get; set; }
        public decimal department { get; set; }
        public int password { get; set; }
        public string loginName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FSDHAssignment1.Model
{
    public class StockIn : Base
    {
        public int Amount { get; set; }
        public int CurrentCount { get; set; }
        public DateTime StockDate { get; set; }
        public virtual int ProductID { get; set; }
        public RetailProduct Product { get; set; }
    }
}

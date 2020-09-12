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
        [ForeignKey("RetailProduct")]
        public int ProductID { get; set; }
        public virtual RetailProduct Product { get; set; }
    }
}

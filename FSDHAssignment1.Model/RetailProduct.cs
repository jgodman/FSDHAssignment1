using System;
using System.Collections.Generic;
using System.Text;

namespace FSDHAssignment1.Model
{
    public class RetailProduct : Base
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockBalance { get; set; }
        public int MOQ { get; set; }
        
    }
}

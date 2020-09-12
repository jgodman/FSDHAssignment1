using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FSDHAssignment1.Model
{
    public class RetailProduct : Base
    {
        //The Name of the retail products are meant to be unique, hence this constaint
        [Index(IsUnique=true)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int StockBalance { get; set; }
        public int MOQ { get; set; }
        
    }
}

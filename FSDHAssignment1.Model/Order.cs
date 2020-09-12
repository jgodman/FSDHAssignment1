using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FSDHAssignment1.Model
{
    public class Order : Base
    {
        public RetailProduct Product { get; set; }
        [ForeignKey("RetailProduct")]
        public int ProductID { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        //Unit price can easily be computed thus: TotalPrice/Amount
        public decimal TotalPrice { get; set; }

    }
}

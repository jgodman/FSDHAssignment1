using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FSDHAssignment1.Models
{
    public class ProductRequest
    {
        public string ProductName { get; set; }
        public int MOQ { get; set; }
        public decimal Price { get; set; }
    }
}

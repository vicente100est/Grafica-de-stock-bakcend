using System;
using System.Collections.Generic;

namespace BakendChart.Models
{
    public partial class Stock
    {
        public int StokId { get; set; }
        public int Quantity { get; set; }
        public int BeerId { get; set; }

        public virtual Beer Stok { get; set; } = null!;
    }
}

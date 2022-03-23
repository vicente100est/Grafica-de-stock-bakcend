using System;
using System.Collections.Generic;

namespace BakendChart.Models
{
    public partial class Brand
    {
        public int BrandId { get; set; }
        public string Name { get; set; } = null!;

        public virtual Beer Beer { get; set; } = null!;
    }
}

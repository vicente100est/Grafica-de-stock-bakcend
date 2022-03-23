using System;
using System.Collections.Generic;

namespace BakendChart.Models
{
    public partial class Beer
    {
        public int BeerId { get; set; }
        public string Name { get; set; } = null!;
        public int BrandId { get; set; }

        public virtual Brand BeerNavigation { get; set; } = null!;
        public virtual Stock Stock { get; set; } = null!;
    }
}

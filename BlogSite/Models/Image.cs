using System;
using System.Collections.Generic;

namespace BlogSite.Models
{
    public partial class Image
    {
        public int ImageId { get; set; }
        public string SmallSize { get; set; }
        public string MediumSize { get; set; }
        public string BigSize { get; set; }
        public string Video { get; set; }
        public Nullable<int> MakaleId { get; set; }
    }
}

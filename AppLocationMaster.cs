using System;
using System.Collections.Generic;

namespace GFAS.Models
{
    public partial class AppLocationMaster
    {
        public Guid Id { get; set; }
        public string? WorkSite { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Latitude { get; set; }
        public string? Range { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BeardMan
{
    public class AvailableCarModel
    {
        public string CarId { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public decimal? PricePerDay { get; set; }
        public decimal? PricePerDayLate { get; set; }
        public int? Year { get; set; }
        public string Gear { get; set; }
        public string ImageFileName { get; set; }
        public int? Km { get; set; }
        public int? CarTypeId { get; set; }
        public bool? IsFixed { get; set; }
        public bool? IsAvailable { get; set; }
        public int? BranchId { get; set; }

        public AvailableCarModel() { }
    }
}

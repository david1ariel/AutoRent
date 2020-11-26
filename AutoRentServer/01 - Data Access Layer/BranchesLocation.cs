using System;
using System.Collections.Generic;

namespace BeardMan
{
    public partial class BranchesLocation
    {
        public int? BranchId { get; set; }
        public int? LocationId { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Location Location { get; set; }
    }
}

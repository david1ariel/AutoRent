﻿using System;
using System.Collections.Generic;

namespace BeardMan
{
    public partial class Branch
    {
        public Branch()
        {
            BranchesAdresses = new HashSet<BranchesAdress>();
            CarsBranches = new HashSet<CarsBranch>();
        }

        public int BranchId { get; set; }
        public int? LocationId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BranchesAdress> BranchesAdresses { get; set; }
        public virtual ICollection<CarsBranch> CarsBranches { get; set; }
    }
}

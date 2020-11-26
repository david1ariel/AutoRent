using System;
using System.Collections.Generic;
using System.Text;

namespace BeardMan
{
    public class BranchModel
    {
        public int BranchId { get; set; }
        public int? LocationId { get; set; }
        public string Name { get; set; }

        public BranchModel() { }

        public BranchModel(Branch branch)
        {
            BranchId = branch.BranchId;
            LocationId = branch.LocationId;
            Name = branch.Name;
        }

        public Branch ConvertToBranch()
        {
            return new Branch
            {
                BranchId = BranchId,
                LocationId = LocationId,
                Name = Name
            };
        }
    }
}

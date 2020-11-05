using System;
using System.Collections.Generic;
using System.Text;

namespace BeardMan
{
    public class BranchModel
    {
        public int BranchId { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }

        public BranchModel(Branch branch)
        {
            BranchId = branch.BranchId;
            Location = branch.Location;
            Name = branch.Name;
        }
    }
}

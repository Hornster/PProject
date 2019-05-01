using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PProject.Models.Repairs
{
    public class RepairListViewModel : ListViewModel<RepairViewModel>
    {
        public int FaultId { get; set; }
    }
}
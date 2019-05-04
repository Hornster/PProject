using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PProject.Models.RepairBills
{
    public class RepairBillListViewModel : ListViewModel<RepairBillViewModel>
    {
        public int RepairId { get; set; }
    }
}
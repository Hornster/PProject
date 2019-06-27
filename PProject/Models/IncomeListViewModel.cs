using System;
using DB.Model.Interfaces;

namespace PProject.Models
{
    public class IncomeListViewModel : ListViewModel<IIncomeData>
    {
        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
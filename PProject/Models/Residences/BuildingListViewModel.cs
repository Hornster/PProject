using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PProject.Models.Residences
{
    /// <summary>
    /// Special type of view model used by BuildingDetails view.
    /// Contains data about selected building.
    /// </summary>
    public class BuildingListViewModel : ListViewModel<ResidenceViewModel>
    {
        public BuildingViewModel Building { get; set; }
    }
}
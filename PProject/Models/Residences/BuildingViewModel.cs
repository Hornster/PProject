using DB.Model.Interfaces;

namespace PProject.Models.Residences
{
    public class BuildingViewModel : IBuildingModel
    {
        public int id_budynku { get; set; }
        public string adres_budynku { get; set; }
    }
}
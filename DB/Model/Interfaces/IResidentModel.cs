using System.Collections.Generic;

namespace DB.Model.Interfaces
{
    public interface IResidentModel
    {
        int id_najemcy { get; set; }
        string nr_telefonu { get; set; }
        string imie { get; set; }
        string nazwisko { get; set; }
        string PESEL { get; set; }
    }
}

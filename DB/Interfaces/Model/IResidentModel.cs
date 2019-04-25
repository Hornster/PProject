using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PProject;

namespace DB.Interfaces.Model
{
    public interface IResidentModel
    {
        int id_najemcy { get; set; }
        string nr_telefonu { get; set; }
        string imie { get; set; }
        string nazwisko { get; set; }
        string PESEL { get; set; }

        ICollection<Wynajmy> Wynajmy { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace DB.Model.Interfaces
{
    public interface IFaultModel
    {
        int id_usterki { get; set; }
        int? id_mieszkania { get; set; }
        string opis { get; set; }
        string stan { get; set; }
    }
}

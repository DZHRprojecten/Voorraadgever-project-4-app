using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App3.Data
{
    [Table("Standaardproductendatabase")]
    class StandaardDB
    {
        [PrimaryKey]
        public string Productnaam { get; set; }
        public int OpNaHoeveelDagen { get; set; }
        public int ProductID { get; set; }

    }
}

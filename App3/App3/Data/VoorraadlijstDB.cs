using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace App3.Data
{
    [Table("Voorraadlijst")]
    class VoorraadlijstDB
    {
        [PrimaryKey]
        public string ProductnaamVL { get; set; }
        public int OpNaHoeveelDagenVL { get; set; }
        public int ProductIDVL { get; set; }
        public int HoeveelProductenVL { get; set; }
        public int MinimaleVoorraad { get; set; }
    }
}

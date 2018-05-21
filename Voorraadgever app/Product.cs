using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Voorraadgever_app
{
    class Product
    {
        public int Productnaam { get; set; }
        public string OpNaHoeveelDagen { get; set; }
        public string ProductID { get; set; }

        public Product(int productnaam, string opNaHoeveelDagen, string productID)
        {
            this.Productnaam = productnaam;
            this.OpNaHoeveelDagen = opNaHoeveelDagen;
            this.ProductID = productID;

        }

        public Product()
        {

        }

        public override string ToString()
        {
            return Productnaam + " - " + OpNaHoeveelDagen;
        }
    }
}
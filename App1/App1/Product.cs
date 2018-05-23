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


namespace Database
{
    class Standaardproductendatabase
    {
        public string Productnaam { get; set; }
        public int OpNaHoeveelDagen { get; set; }
        public int ProductID { get; set; }
        
        
        public Standaardproductendatabase(string productnaam, int opNaHoeveelDagen, int productID)
        {
            this.Productnaam = productnaam;
            this.OpNaHoeveelDagen = opNaHoeveelDagen;
            this.ProductID = productID;
        }

        public Standaardproductendatabase()
        {

        }

        public override string ToString()
        {
            return Productnaam + " - " + ProductID;
        }
    }
    class Boodschappenlijst
    {
        public string ProductNaamBL { get; set; }
        public int OpNaHoeveelDagenBL { get; set; }
        public int ProductDBL { get; set; }
        public int HoeveelProductenBL { get; set; }


        public Boodschappenlijst(string productNaamBL, int opNaHoeveelDagenBL, int productDBL, int hoeveelProductenBL)
        {
            this.ProductNaamBL = productNaamBL;
            this.OpNaHoeveelDagenBL = opNaHoeveelDagenBL;
            this.ProductDBL = productDBL;
            this.HoeveelProductenBL = hoeveelProductenBL;
        }

        public Boodschappenlijst()
        {

        }
        public override string ToString()
        {
            return ProductNaamBL + " - " + HoeveelProductenBL;
        }
    }
    class Voorraadlijst
    {
        public string ProductNaamVL { get; set; }
        public int OpNaHoeveelDagenVL { get; set; }
        public int ProductDVL { get; set; }
        public int HoeveelProductenVL { get; set; }

        public Voorraadlijst(string productNaamVL, int opNaHoeveelDagenVL, int productDVL, int hoeveelProductenVL)
        {
            this.ProductNaamVL = productNaamVL;
            this.OpNaHoeveelDagenVL = opNaHoeveelDagenVL;
            this.ProductDVL = productDVL;
            this.HoeveelProductenVL = hoeveelProductenVL;
        }

        public Voorraadlijst()
        {

        }
        public override string ToString()
        {
            return ProductNaamVL + " - " + HoeveelProductenVL;
        }
    }
}
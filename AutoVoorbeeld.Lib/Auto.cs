using System;

namespace AutoVoorbeeld.Lib
{
    public partial class Auto
    {
        public string merk;
        public string kleur;
        public decimal prijs;
        public static int aantalAutos;

        public Auto() // Default constructor
        {
            merk = null;
            kleur = null;
            prijs = 0;
            aantalAutos++;
        }

        public Auto(string merk):this() // Constructor ontvangt 1 parameter
        {
            this.merk = merk;
        }

        public Auto(string merk, string kleur):this() // Constructor ontvangt 2 parameters
        {
            this.merk = merk;
            this.kleur = kleur;
        }

        public Auto(string merk, string kleur, decimal prijs):this() // Constructor ontvangt 3 parameters
        {
            this.merk = merk;
            this.kleur = kleur;
            this.prijs = prijs;
        }
    }
}

using System;

namespace AutoVoorbeeld.Lib
{
    public partial class Auto
    {
        public decimal PrijsVerschil(Auto wagen)
        {
            return Math.Abs(this.prijs - wagen.prijs);
        }

        public static decimal PrijsVerschil(Auto wagen1, Auto wagen2)
        {
            return Math.Abs(wagen1.prijs - wagen2.prijs);
        }

        public override string ToString()
        {
            string autoInfo = $"{merk} - {kleur}";
            return autoInfo; 
        }
    }
}

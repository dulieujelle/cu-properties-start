using AutoVoorbeeld.Lib;
using System;

namespace AutoVoorbeeld.Cons
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto nieuweAuto;
            nieuweAuto = new Auto();

            nieuweAuto.kleur = "zwart";
            nieuweAuto.merk = "Hyundai";
            nieuweAuto.prijs = 15000M;

            Auto tweedeAuto;
            tweedeAuto = new Auto();

            tweedeAuto.kleur = "wit";
            tweedeAuto.merk = "Ford";
            tweedeAuto.prijs = 9000M;

            Auto derdeAuto = new Auto("Audi", "blauw", 25000M);

            decimal kostprijsVerschil = Auto.PrijsVerschil(nieuweAuto, derdeAuto);

            var anoniempje = new { Naam = "Peter", Leeftijd = 40 };

            Console.WriteLine($"De nieuwe auto is een {nieuweAuto.merk}, is {nieuweAuto.kleur} van kleur en kost {nieuweAuto.prijs}");
            Console.WriteLine("============");
            Console.WriteLine($"De tweede auto is een {tweedeAuto.merk}, is {tweedeAuto.kleur} van kleur en kost {tweedeAuto.prijs}");
            Console.WriteLine("============");
            Console.WriteLine($"De derde auto is een {derdeAuto.merk}, is {derdeAuto.kleur} van kleur en kost {derdeAuto.prijs}");
            Console.WriteLine("============");
            Console.WriteLine($"We hebben nu {Auto.aantalAutos} auto's");

            Console.WriteLine("============");
            Console.WriteLine($"Prijsverschil tussen {nieuweAuto.prijs} en {derdeAuto.prijs} is {kostprijsVerschil}");

            Console.WriteLine("============");
            Console.WriteLine($"Anoniempje heet {anoniempje.Naam} en is van het type {anoniempje.GetType().Name}");
            Console.ReadLine();
        }
    }
}

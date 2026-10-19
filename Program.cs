using System;
using System.Collections.Generic;
using System.Globalization;

class Samochod
{
    public string Marka = "";
    public string Model = "";
    public int RokProdukcji;
    public double Przebieg;
    public double IloscPaliwa;
    public double PrzejechanyDystans;

    public double ObliczSpalanie()
    {
        return IloscPaliwa / PrzejechanyDystans * 100;
    }

    public void WyswietlInformacje()
    {
        Console.WriteLine($"{Marka} {Model}");
        Console.WriteLine($"Rok produkcji: {RokProdukcji}");
        Console.WriteLine($"Przebieg: {Przebieg} km");
        Console.WriteLine($"Przejechany dystans: {PrzejechanyDystans} km");
        Console.WriteLine($"Zużyte paliwo: {IloscPaliwa} l");
        Console.WriteLine($"Średnie spalanie: {ObliczSpalanie():F2} l/100 km");
        Console.WriteLine();
    }

    public bool CzyEkonomiczny()
    {
        return ObliczSpalanie() < 6.5;
    }
}

class Program
{
    static void Main()
    {
        CultureInfo.CurrentCulture = new CultureInfo("pl-PL");

        Console.WriteLine("BorrowCar");

        List<Samochod> samochody = new List<Samochod>();

        for (int i = 0; i < 3; i++)
        {
            Samochod samochod = new Samochod();

            Console.WriteLine($"\nSamochód {i + 1}");

            Console.Write("Marka: ");
            samochod.Marka = Console.ReadLine() ?? "";

            Console.Write("Model: ");
            samochod.Model = Console.ReadLine() ?? "";

            Console.Write("Rok produkcji: ");
            samochod.RokProdukcji = Convert.ToInt32(Console.ReadLine());

            Console.Write("Przebieg [km]: ");
            samochod.Przebieg = Convert.ToDouble(Console.ReadLine());

            do
            {
                Console.Write("Przejechany dystans [km] (większy od 0): ");
                samochod.PrzejechanyDystans = Convert.ToDouble(Console.ReadLine());
            }
            while (samochod.PrzejechanyDystans <= 0);

            do
            {
                Console.Write("Zużyte paliwo [l] (nieujemne): ");
                samochod.IloscPaliwa = Convert.ToDouble(Console.ReadLine());
            }
            while (samochod.IloscPaliwa < 0);

            samochody.Add(samochod);
        }

        Console.WriteLine("\nWszystkie samochody:");

        foreach (Samochod samochod in samochody)
        {
            samochod.WyswietlInformacje();
        }

        Samochod najlepszy = samochody[0];

        foreach (Samochod samochod in samochody)
        {
            if (samochod.ObliczSpalanie() < najlepszy.ObliczSpalanie())
            {
                najlepszy = samochod;
            }
        }

        Console.WriteLine("Samochód o najmniejszym spalaniu:");
        najlepszy.WyswietlInformacje();

        Console.WriteLine("Samochody ekonomiczne (spalanie poniżej 6,5 l/100 km):");

        bool znaleziono = false;

        foreach (Samochod samochod in samochody)
        {
            if (samochod.CzyEkonomiczny())
            {
                samochod.WyswietlInformacje();
                znaleziono = true;
            }
        }

        if (!znaleziono)
        {
            Console.WriteLine("Brak samochodów spełniających warunek.");
        }
    }
}

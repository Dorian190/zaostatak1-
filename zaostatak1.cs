using System;

class KlasaC
{
    public int Zbroj(int[] niz)
    {
        int zbroj = 0;
        foreach (int broj in niz)
        {
            zbroj += broj;
        }
        return zbroj;
    }

    public double Prosjek(int[] niz)
    {
        int zbroj = Zbroj(niz);
        double prosjek = (double)zbroj / niz.Length;
        return prosjek;
    }
}

class Program
{
    static void Main(string[] args)
    {
        KlasaC objekt = new KlasaC();

        int[] unos = new int[5];

        Console.WriteLine("Unesite 5 cijelih brojeva:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Broj {i + 1}: ");
            unos[i] = Convert.ToInt32(Console.ReadLine());
        }

        int zbroj = objekt.Zbroj(unos);
        double prosjek = objekt.Prosjek(unos);

        Console.WriteLine($"Zbroj unesenih brojeva je: {zbroj}");
        Console.WriteLine($"Prosjek unesenih brojeva je: {prosjek}");

        Console.ReadLine();
    }
}


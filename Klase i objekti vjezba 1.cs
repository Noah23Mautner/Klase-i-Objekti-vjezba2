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
        if (niz.Length == 0)
            return 0;

        int zbroj = Zbroj(niz);
        return (double)zbroj / niz.Length;
    }
}

class Program
{
    static void Main()
    {
        KlasaC objektKlasaC = new KlasaC();

        int[] unosNiza = new int[5];
        Console.WriteLine("Unesite 5 cijelih brojeva:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Unesite broj " + (i + 1) + ": ");
            if (int.TryParse(Console.ReadLine(), out int broj))
            {
                unosNiza[i] = broj;
            }
            else
            {
                Console.WriteLine("Neispravan unos. Molimo unesite cijeli broj.");
                i--;
            }
        }

        int zbroj = objektKlasaC.Zbroj(unosNiza);
        double prosjek = objektKlasaC.Prosjek(unosNiza);

        Console.WriteLine("Zbroj elemenata niza: " + zbroj);
        Console.WriteLine("Prosjek elemenata niza: " + prosjek);
    }
}

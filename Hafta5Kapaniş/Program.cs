using System;
using System.Collections.Generic;

class Araba
{
    public DateTime UretimTarihi { get; private set; }
    public string SeriNumarasi { get; set; }
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }
    public int KapiSayisi { get; set; }

    public Araba()
    {
        UretimTarihi = DateTime.Now;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Araba> arabalar = new List<Araba>();
        string cevap;

        while (true)
        {
            Console.WriteLine("Araba üretmek istiyor musunuz? (E/H)");
            cevap = Console.ReadLine().ToLower();

            if (cevap == "e")
            {
                Araba yeniAraba = new Araba();

                Console.Write("Seri Numarası: ");
                yeniAraba.SeriNumarasi = Console.ReadLine();

                Console.Write("Marka: ");
                yeniAraba.Marka = Console.ReadLine();

                Console.Write("Model: ");
                yeniAraba.Model = Console.ReadLine();

                Console.Write("Renk: ");
                yeniAraba.Renk = Console.ReadLine();

                // Kapı sayısını al ve kontrol et
                while (true)
                {
                    Console.Write("Kapı Sayısı: ");
                    string kapıSayisiInput = Console.ReadLine();
                    if (int.TryParse(kapıSayisiInput, out int kapıSayisi))
                    {
                        yeniAraba.KapiSayisi = kapıSayisi;
                        break; // Geçerli bir sayı alındı, döngüden çık
                    }
                    else
                    {
                        Console.WriteLine("Lütfen geçerli bir sayı girin.");
                    }
                }

                arabalar.Add(yeniAraba);
            }
            else if (cevap == "h")
            {
                break; // Programı sonlandır
            }
            else
            {
                Console.WriteLine("Geçersiz cevap. Lütfen 'E' veya 'H' girin.");
            }
        }

        // Arabaların seri numaralarını ve markalarını yazdır
        Console.WriteLine("\nÜretilen Arabalar:");
        foreach (var araba in arabalar)
        {
            Console.WriteLine($"Seri Numarası: {araba.SeriNumarasi}, Marka: {araba.Marka}");
        }
    }
}
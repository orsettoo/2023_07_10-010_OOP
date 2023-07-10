class Kisi
{
    public string Adi { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        int sayi1, sayi2;
        sayi1 = 5;
        sayi2 = sayi1;

        Console.WriteLine("1. sayı = " + sayi1);
        Console.WriteLine("2. sayı = " + sayi2);
        Console.WriteLine("-------------------");
        sayi2 = 10;
        Console.WriteLine("1. sayı = " + sayi1);
        Console.WriteLine("2. sayı = " + sayi2);
        Console.WriteLine();

        Kisi kisi1, kisi2;
        kisi1 = new Kisi();
        kisi1.Adi = "Lizge";
        kisi2 = kisi1;

        Console.WriteLine("1. kisi = " + kisi1.Adi);
        Console.WriteLine("2. kisi = " + kisi2.Adi);
        Console.WriteLine("-------------------");

        kisi2.Adi = "Özge";
        Console.WriteLine("1. kisi = " + kisi1.Adi);
        Console.WriteLine("2. kisi = " + kisi2.Adi);


    }
}

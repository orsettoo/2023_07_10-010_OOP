class Program
{
    static void Main(string[] args)
    {
        Kisi kisi = new Kisi() { Adi = "Özge", Soyadi = "Doblan" };
        kisi.Hakkinda();

        Calisan calisan = new Calisan()
        {
            Adi = "Arda",
            Soyadi = "Büyükdoluca",
            Sirket = "Microsoft"
        };
        calisan.Hakkinda();
        calisan.MaasAl();
        calisan.MaasAl();
        calisan.FinansalDurum();

        Mudur mudur = new Mudur(700) 
        {
            Adi = "Berat",  
            Soyadi = "Genç", 
            Sirket = "Google", 
            Pozisyon = "Dev Man" 
        };
        mudur.Hakkinda();
    }
}

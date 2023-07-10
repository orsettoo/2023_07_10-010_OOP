class Calisan : Kisi
{
    public string Sirket { get; set; }
    private int ToplamPara = 1000;
    protected int Maas;

    public Calisan(int maas)
    {
        Maas = maas;
    }
    public Calisan() : this(300)
    {

    }

    public override void Hakkinda()
    {
        Console.WriteLine("Ben " + TamAdi + " " + Sirket + " sirketinde calisiyorum");
    }

    public void MaasAl()
    {
        ToplamPara += Maas;
        Console.WriteLine("Maas Aldı");
    }
    public void FinansalDurum()
    {
        Console.WriteLine("Maas = " + Maas + " Toplam " + ToplamPara);
    }

}

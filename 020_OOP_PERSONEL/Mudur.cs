class Mudur : Calisan
{
    public string Pozisyon { get; set; }

    public Mudur(int maas) : base(maas)
    {

    }

    public override void Hakkinda()
    {
        Console.WriteLine(Sirket + "Şirketinde , Pozisyon =" + Pozisyon + " Olarak  Çalışıyorum");
        Console.WriteLine(" Ben " + TamAdi);
    }
    public void ZamAl(int zamMiktari)
    {
        Maas = Maas + zamMiktari;
    }
}

class Kisi
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public string TamAdi
    {
        get { return Adi + " " + Soyadi.ToUpper(); }
    }
    public virtual void Hakkinda()
    {
        Console.WriteLine("Ben " + TamAdi);
    }
}

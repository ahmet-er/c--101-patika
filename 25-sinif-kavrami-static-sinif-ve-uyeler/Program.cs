// See https://aka.ms/new-console-template for more information


Console.WriteLine("Calisan Sayisi: {0}",Calisan.CalisanSayisi);// public property e erismis olduk

Calisan calisan = new Calisan("Ayse", "Yılmaz", "IK");
Console.WriteLine("Calisan Sayisi: {0}",Calisan.CalisanSayisi);
Calisan calisan1 = new Calisan("Ayse1", "Yılmaz1", "IK1");
Calisan calisan2 = new Calisan("Ayse2", "Yılmaz2", "IK2");
Console.WriteLine("Calisan Sayisi: {0}",Calisan.CalisanSayisi);

// static clasa erisim
Console.WriteLine("toplama islemi sonucu: {0}", Islemler.Topla(100,200));
Console.WriteLine("cikarma islemi sonucu: {0}", Islemler.Cikar(500,40));


Console.ReadKey();

class Calisan
{
    private static int calisanSayisi;

    public static int CalisanSayisi { get => calisanSayisi;}

    private string Isim;
    private string Soyisim;
    private string Departman;

    static Calisan()//static kurucularin erisim belirteci olmaz
    {
        calisanSayisi = 0;
    }
    public Calisan(string ısim, string soyisim, string departman)
    {
        this.Isim = ısim;
        this.Soyisim = soyisim;
        this.Departman = departman;
        calisanSayisi++;
    }

}

static class Islemler
{// static classlara kalıtım islemi uygulanamaz
    public static long Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }
    public static long Cikar(int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    }
}

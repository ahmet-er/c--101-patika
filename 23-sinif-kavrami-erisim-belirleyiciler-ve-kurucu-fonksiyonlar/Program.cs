// See https://aka.ms/new-console-template for more information

// Söz Dizimi
// class SinifAdi
// {
//     [Erisim Belirleyici] [Veri Tipi] OzellikAdi;
//     [Erisim Belirleyici] [Geri Donus Tipi] MetotAdi([Parametre Listesi])
//     {
//         MethodAccessException Komutlari
//     }
// }

/*
Erişim Belirleyiciler
    * Public -> heryerden erisilebilir
    * Private -> sadece tanımlandıgı sinif icerisinde erisilir
    * Internal -> sadece bu projede (program.cs)
    * Protected -> bu class veya bundan kalıtılan classlarda kullanılır
*/

Console.WriteLine("***** Calisan 1 *****");
Calisan calisan1 = new Calisan("Ayse", "Kara", 12345678, "İnsan Kaynaklari");
// calisan1.Ad="Ayse";
// calisan1.Soyad="Kara";
// calisan1.No=12345678;
// calisan1.Departman="İnsan Kaynaklari";

calisan1.CalisanBilgileri();

Console.WriteLine("***** Calisan 2 *****");
Calisan calisan2 = new Calisan();
calisan2.Ad="Ahmet";
calisan2.Soyad="Er";
calisan2.No=12345678;
calisan2.Departman="Yazilim Gelistirme";

calisan2.CalisanBilgileri();

Console.WriteLine("***** Calisan 3 *****");
Calisan calisan3 = new Calisan("Fatih", "Ozcan");

calisan3.CalisanBilgileri();

Console.ReadKey();

class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public Calisan(string ad, string soyad, int no, string departman)
    {//Kurucu fonksiyon
        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
        this.Departman = departman;
    }

    public Calisan(string ad, string soyad)
    {//Kurucu fonksiyon asırı yüklenebilir (overload)
        this.Ad = ad;
        this.Soyad = soyad;
    }

    public Calisan(){}

    public void CalisanBilgileri()
    {
        Console.WriteLine("Calisan Adi: {0}", Ad);
        Console.WriteLine("Calisan Soyadi: {0}", Soyad);
        Console.WriteLine("Calisan Numarasi: {0}", No);
        Console.WriteLine("Calisan Departmani: {0}", Departman);
    }
}

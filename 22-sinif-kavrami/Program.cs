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

Calisan calisan1 = new Calisan();
calisan1.Ad="Ayse";
calisan1.Soyad="Kara";
calisan1.No=12345678;
calisan1.Departman="İnsan Kaynaklari";
calisan1.CalisanBilgileri();

Console.WriteLine("---------------------------");

Calisan calisan2 = new Calisan();
calisan2.Ad="Ahmet";
calisan2.Soyad="Er";
calisan2.No=12345678;
calisan2.Departman="Yazilim Gelistirme";
calisan2.CalisanBilgileri();

Console.ReadKey();

class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    public void CalisanBilgileri()
    {
        Console.WriteLine("Calisan Adi: {0}", Ad);
        Console.WriteLine("Calisan Soyadi: {0}", Soyad);
        Console.WriteLine("Calisan Numarasi: {0}", No);
        Console.WriteLine("Calisan Departmani: {0}", Departman);
    }
}



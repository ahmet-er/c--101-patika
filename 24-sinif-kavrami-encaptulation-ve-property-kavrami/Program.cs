// See https://aka.ms/new-console-template for more information

Ogrenci ogrenci = new Ogrenci();
ogrenci.Isim = "Ayse";
ogrenci.Soyisim = "Yılmaz";
ogrenci.OgrenciNo = 4342;
ogrenci.Sinif = 3; //setteri kapattıgımızda burada atama yapamazdik
ogrenci.OgrenciBilgileriniGetir();

ogrenci.SinifAtlat();

ogrenci.OgrenciBilgileriniGetir();

Ogrenci ogrenci1 = new Ogrenci("Deniz", "Arda", 676, 1);
ogrenci1.SinifDusur();
ogrenci1.SinifDusur();
ogrenci1.OgrenciBilgileriniGetir();


Console.ReadKey();


class Ogrenci
{
    private string isim;//Encaptulation private field lari getter ve setter ile class dısında kullanmamiza yarar (ctrl + .) kısayolu ile kolayca getter ve setter metotlari olusturabiliriz

    private string soyisim;

    private int ogrenciNo;

    private int sinif;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sinif 
    { 
        get => sinif;
        set 
        {//Sinif en dusuk 1 olacagi icin burada logic veriyoruz
            if(value < 1)
            {
                Console.WriteLine("Sınıf En Az 1 Olabilir!");
                sinif = 1;
            }
            else
                sinif = value;
        }
    }

    public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)//Kurucu(Constructor fonksiyona field lari (ctrl + .) kısayolu ile hızlıca ekleyebiliriz)
    {
        Isim = ısim;
        Soyisim = soyisim;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }

    public Ogrenci(){}

    public void OgrenciBilgileriniGetir()
    {
        Console.WriteLine("***** Ogrenci Bilgileri *****");
        Console.WriteLine("Ogrenci Adi        :{0}",this.Isim);
        Console.WriteLine("Ogrenci Soyadi     :{0}",this.Soyisim);
        Console.WriteLine("Ogrenci No         :{0}",this.OgrenciNo);
        Console.WriteLine("Ogrenci Sinif      :{0}",this.Sinif);
    }

    public void SinifAtlat()
    {
        this.Sinif += 1;
    }
    public void SinifDusur()
    {
        this.Sinif -= 1;
    }
}
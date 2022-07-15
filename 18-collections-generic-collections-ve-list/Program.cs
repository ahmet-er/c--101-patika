// See https://aka.ms/new-console-template for more information

// List<T> class
// System.Collections.Generic
// T -> object türündedir
Console.WriteLine("------------------");
List<int> sayiListesi = new List<int>();
sayiListesi.Add(23);
sayiListesi.Add(10);
sayiListesi.Add(4);
sayiListesi.Add(5);
sayiListesi.Add(92);
sayiListesi.Add(34);

List<string> renkListesi = new List<string>();
renkListesi.Add("Kırmızı");
renkListesi.Add("Mavi");
renkListesi.Add("Turuncu");
renkListesi.Add("Sarı");
renkListesi.Add("Yeşil");

// Count
Console.WriteLine(renkListesi.Count);
Console.WriteLine("------------------");
Console.WriteLine(sayiListesi.Count);
Console.WriteLine("------------------");

// Foreach ve List.ForEach ile elemanlara erişim
foreach (var sayi in sayiListesi)
    Console.WriteLine(sayi);
Console.WriteLine("------------------");
foreach (var renk in renkListesi)
    Console.WriteLine(renk);
Console.WriteLine("------------------");

sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
Console.WriteLine("------------------");
renkListesi.ForEach(renk => Console.WriteLine(renk));
Console.WriteLine("------------------");

// Listeden eleman çıkarma
sayiListesi.Remove(4);       // Elemanın value-degerini yazarak cıkartır
renkListesi.Remove("Yeşil");

sayiListesi.RemoveAt(0);     // Elemanın indisini yazarak çıkartır
renkListesi.RemoveAt(1);

sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
Console.WriteLine("------------------");
renkListesi.ForEach(renk => Console.WriteLine(renk));
Console.WriteLine("------------------");

// Liste içerisinde Arama
if (sayiListesi.Contains(10))
{
    Console.WriteLine("10 liste içerisinde bulundu!");
}
Console.WriteLine("------------------");

// Eleman ile index'e erişme
Console.WriteLine(renkListesi.BinarySearch("Sarı"));
Console.WriteLine("------------------");

// Diziyi List'e çevirme
string[] hayvanlar = {"Kedi", "Köpek", "Kuş"};
List<string> hayvanListesi = new List<string>(hayvanlar);

// Listeti nasıl temizleri?
hayvanListesi.Clear();

// List içerisinde nesne tutmak
List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

Kullanıcılar kullanıcı1 = new Kullanıcılar();
kullanıcı1.Isim="Ayse";
kullanıcı1.Soyisim="Yılmaz";
kullanıcı1.Yas=26;

Kullanıcılar kullanıcı2 = new Kullanıcılar();
kullanıcı2.Isim="Ozcan";
kullanıcı2.Soyisim="Caliskan";
kullanıcı2.Yas=26;

kullanıcıListesi.Add(kullanıcı1);
kullanıcıListesi.Add(kullanıcı2);

List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();

yeniListe.Add(new Kullanıcılar(){
    Isim="Deniz",
    Soyisim="Arda",
    Yas=24
});

foreach (var kullanıcı in kullanıcıListesi)
{
    Console.WriteLine("Kullanıcı Adı: " + kullanıcı.Isim);
    Console.WriteLine("Kullanıcı Soyismi: " + kullanıcı.Soyisim);
    Console.WriteLine("Kullanıcı Yası: " + kullanıcı.Yas);
}

yeniListe.Clear();
Console.WriteLine("------------------");






Console.ReadKey();

public class Kullanıcılar{
    string isim;
    string soyisim;
    int yas;

    public string Isim { get =>isim; set => isim = value;}
    public string Soyisim { get =>soyisim; set => soyisim = value;}
    public int Yas { get =>yas; set => yas = value;}
}
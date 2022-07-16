// See https://aka.ms/new-console-template for more information

// Odev - 2 --- Soru - 3

/*Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.*/

Console.Write("Lütfen metni giriniz: ");
string metin = Console.ReadLine().ToLower();
string sesli = "aeıioöuü";
List<char> sesliHarfler = new List<char>();

// sesli harf kontrolu ve atamasi
int sayac=0;
for (int i = 0; i < metin.Length; i++)
{
    //karakter karakter kontrol ediyoruz
    if (sesli.Contains(metin[i]))
    {
        sayac++;
        sesliHarfler.Add(metin[i]);
    }
}

// sesli harfleri yazdir
Console.WriteLine("***** Sesli Harfler *****");
foreach (var item in sesliHarfler)
{
    Console.Write(item);
}
Console.WriteLine("");

// sırali sesli harfler yazdir
Console.WriteLine("***** Sıralı Sesli Harfler *****");
sesliHarfler.Sort();
foreach (var item in sesliHarfler)
{
    Console.Write(item);
}

Console.WriteLine("");
Console.WriteLine("--------------------------------");
// sesli harf sayacı
Console.WriteLine("sesli harf sayisi: " + sayac);

Console.ReadKey();
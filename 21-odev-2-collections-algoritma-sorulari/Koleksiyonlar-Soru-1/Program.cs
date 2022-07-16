// See https://aka.ms/new-console-template for more information

// Odev - 2 --- Soru - 1

/*Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanarak yazınız.)

Negatif ve numeric olmayan girişleri engelleyin.
Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.*/

using System.Collections;

ArrayList asalSayilar = new ArrayList();
ArrayList asalOlmayanSayilar = new ArrayList();

// giris yapilan sayilarin ArrayListe atanması ve hatalı giris kontrolu
for (int i = 0; i < 20; i++)
{
    Console.Write("Lütfen {0}. sayiyi giriniz: ", i+1);
    try
    {
        int sayi =Convert.ToInt32(Console.ReadLine());
        if(sayi<=0)
        {
            Console.WriteLine("Lütfen sadece pozitif sayilar giriniz!");
        }
        else
        {
            if (AsalSayi(sayi))
            {
                asalSayilar.Add(sayi);
            }
            else
            {
                asalOlmayanSayilar.Add(sayi);
            }
        }
            
    }
    catch(Exception e)
    {
        Console.WriteLine("Lütfen sadece nümaratik degerler giriniz!");
    }
}

Console.WriteLine("***** Asal Sayilar *****");
foreach (var item in asalSayilar)
    Console.WriteLine(item);

Console.WriteLine("***** Asal Olmayan Sayilar *****");
foreach (var item in asalOlmayanSayilar)
    Console.WriteLine(item);

// kücük -> büyük siralama
asalSayilar.Sort();
asalOlmayanSayilar.Sort();

// Ters cevirme
asalSayilar.Reverse();
asalOlmayanSayilar.Reverse();

Console.WriteLine("***** [Sıralı(büyük->kücük)] Asal Sayilar *****");
foreach (var item in asalSayilar)
    Console.WriteLine(item);

Console.WriteLine("***** [Sıralı(büyük->kücük)] Asal Olmayan Sayilar *****");
foreach (var item in asalOlmayanSayilar)
    Console.WriteLine(item);

// ArrayListlerin eleman sayilarini yazdirma
Console.WriteLine("-----------------------------");
Console.WriteLine("Asal Sayıların Sayisi: " + asalSayilar.Count);
Console.WriteLine("Asal Olmayan Sayıların Sayisi: " + asalOlmayanSayilar.Count);

// Eleman toplamlari
int asalToplam = 0;
int asalOlmayanToplam = 0;
foreach (int item in asalSayilar)
{
    asalToplam += item;
}
foreach (int item in asalOlmayanSayilar)
{
    asalOlmayanToplam += item;
}
Console.WriteLine("-----------------------------");
Console.WriteLine("Asal Sayıların Ortalamasi: " + (asalToplam / asalSayilar.Count));
Console.WriteLine("Asal Olmayan Sayıların Ortalamasi: " + (asalOlmayanToplam / asalOlmayanSayilar.Count));


// asal olup olmadigini bool olarak donduren methot
static bool AsalSayi(int s)
{
    bool result = true;
    for (int i = 2; i < s-1; i++)
    {
        if (s % i == 0)
        {
            result = false;
            i=s;
        }
    }
    if (s<2)
    {
        result=false;
    }
    return result;
}







Console.ReadKey();
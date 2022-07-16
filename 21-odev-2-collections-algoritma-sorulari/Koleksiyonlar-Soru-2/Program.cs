// See https://aka.ms/new-console-template for more information

// Odev - 2 --- Soru - 2

/*Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)*/

using System.Collections;

ArrayList sayilar = new ArrayList();
int[] kucuk= new int[3];
int[] buyuk= new int[3];

for(int i=0;i<20;i++)
{
    
    try
    {
        Console.Write("Lütfen {0}. sayiyi giriniz: ", i+1);
        int sayi = int.Parse(Console.ReadLine());

        if(sayi<=0)
        {
            Console.WriteLine("Lütfen sadece pozitif sayi giriniz!");
        }
        else
        {
            sayilar.Add(sayi);
        }
    }
    catch (System.Exception)
    {
        Console.WriteLine("Lütfen sadece nümaretik değer giriniz!");
        //throw;
    }
}
Console.WriteLine("***** İlk yazdirma *****");
// Yazdirma
foreach (var item in sayilar)
{
    Console.WriteLine(item);
}

sayilar.Sort();

for (int i = 0; i < 3; i++)
{
    kucuk[i] = (int)sayilar[i];
}


Console.WriteLine("***** En kücük üclü *****");
// en kücük ilk 3 lü
foreach (var item in kucuk)
{
    Console.WriteLine(item);
}

sayilar.Reverse();
for (int i = 0; i < 3; i++)
{
    buyuk[i] = (int)sayilar[i];
}

Console.WriteLine("***** En büyük üclü *****");
// en kücük ilk 3 lü
foreach (var item in buyuk)
{
    Console.WriteLine(item);
}

Console.WriteLine("---------");
int kTop=0;
int bTop=0;
for (int i = 0; i < kucuk.Length; i++)
{
    kTop += kucuk[i];
    bTop += buyuk[i];
}

Console.WriteLine("***** Üclülerin Ortalamalari *****");
Console.WriteLine("En Kücük Üclünün ortalamasi = " + (kTop/3));
Console.WriteLine("---------");
Console.WriteLine("En Büyük Üclünün ortalamasi = " + (bTop/3));




Console.ReadKey();
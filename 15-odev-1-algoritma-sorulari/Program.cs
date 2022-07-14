// See https://aka.ms/new-console-template for more information


//Odev-1

/*1.Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.*/


Console.WriteLine("***** ODEV - 1 *****");
Console.WriteLine("Lütfen pozitif bir sayi giriniz");
int diziUzunlugu = Convert.ToInt32(Console.ReadLine());
int[] dizi = new int[diziUzunlugu];

for (int i = 0; i < diziUzunlugu; i++)
{
    Console.Write("Lütfen {0}. sayısı giriniz: ", i+1);
    dizi[i] = int.Parse(Console.ReadLine());
    
}
foreach (var sayi in dizi)
{
    if (sayi%2==0)
    {
        Console.WriteLine(sayi);      
    }
}

Console.WriteLine("***** ODEV - 2 *****");
/*2.Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.*/
Console.WriteLine("Lütfen pozitif ilk sayi giriniz(Dizi boyutu): ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Lütfen pozitif ikinci sayi giriniz(Bölüm): ");
int m = int.Parse(Console.ReadLine());

int[] ikinciDizi= new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write("Lütfen {0}. sayiyi giriniz: ", i+1);
    ikinciDizi[i] = int.Parse(Console.ReadLine());    
}

foreach (var sayi in ikinciDizi)
{
    if (sayi % m == 0 || sayi == m)
        Console.WriteLine(sayi); 
}

Console.WriteLine("***** ODEV - 3 *****");
/*Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.*/
Console.WriteLine("Lütfen pozitif bir sayi giriniz(kelime sayisi)");
int kelimeSayisi = int.Parse(Console.ReadLine());
string[] kelimeler = new string[kelimeSayisi];

for (int i = 0; i < kelimeSayisi; i++)
{
    Console.Write("Lütfen {0}. kelimeyi giriniz: ", i+1);
    kelimeler[i] = Console.ReadLine();
}

Array.Reverse(kelimeler);

foreach (var kelime in kelimeler)
{
    Console.WriteLine(kelime);
}

Console.WriteLine("***** ODEV - 4 *****");
/*Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.*/
Console.WriteLine("Lütfen Kelime ve Harf kontrolü için bir Cümle giriniz: ");
string cümle = Console.ReadLine();

Console.WriteLine("Girdiginiz cümlenin uzunlugu: " + cümle.Length);

string[] words = cümle.Split(' ');
Console.WriteLine("Girdiginiz cümledeki kelime sayisi: " + words.Length);






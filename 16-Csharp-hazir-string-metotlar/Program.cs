// See https://aka.ms/new-console-template for more information

string degisken = "Dersimiz CSharp, Hosgeldiniz!";
string degisken2 = "CSharp";

// Length;
Console.WriteLine(degisken.Length);

// ToUpper, ToLower
Console.WriteLine(degisken.ToUpper());
Console.WriteLine(degisken.ToLower());

// Concat
Console.WriteLine(String.Concat(degisken,"Merhaba")); //string sonuna belirtilen stringi ekler

// Compare, CompareTo
Console.WriteLine(degisken.CompareTo(degisken2));//0, 1, -1 döndürür
Console.WriteLine(String.Compare(degisken, degisken2, true));
Console.WriteLine(String.Compare(degisken, degisken2, false));

// Contains
Console.WriteLine(degisken.Contains(degisken2)); //degisken, degisken2 yi iceriryorsa true dondurur
Console.WriteLine(degisken.EndsWith("Hosgeldiniz!"));//true
Console.WriteLine(degisken.StartsWith("Merhaba!"));//false

// IndexOf
Console.WriteLine(degisken.IndexOf("CS"));//9. karakterde bunu buldu icin 9 doner
Console.WriteLine(degisken.IndexOf("ahmet"));//bulamadıgında -1 doner

// Insert
Console.WriteLine(degisken.Insert(0,"Merhaba! "));

// LastIndexOf
Console.WriteLine(degisken.LastIndexOf("i"));//sondan basladi aramaya

// PadLeft, PadRight
Console.WriteLine(degisken + degisken2.PadLeft(30));//ifade 30 karakterden az ise soluna 30 karakter olacak sekilde bosluk ekler, 30 dan fazla ise hiçbirsey yapmaz.
Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));//yukardaki aynisi bosluk yerine * basar
Console.WriteLine(degisken.PadRight(50) + degisken2);//ifade 50 karakterden az ise sagina 50 karakter olacak sekilde bosluk ekler, 50 dan fazla ise hiçbirsey yapmaz.
Console.WriteLine(degisken.PadRight(50, '-') + degisken2);//yukardaki aynisi bosluk yerine - basar

// Remove
Console.WriteLine(degisken.Remove(10));
Console.WriteLine(degisken.Remove(5,3));
Console.WriteLine(degisken.Remove(0,1));

// Replace
Console.WriteLine(degisken.Replace("CSharp", "C#"));
Console.WriteLine(degisken.Replace(" ", "*"));

// Split
Console.WriteLine(degisken.Split(' ')[1]); // ilk belittigimiz bu ornekte bosluk olan yerlerden stringi ayırır 1.yi getir sadece

// Substring
Console.WriteLine(degisken.Substring(4)); // Split gibi ayırır(ama bosluk yok herseyi ayırır) ve 4 ten sonrasını getir anlamı var
Console.WriteLine(degisken.Substring(4,6));// ayırır ve 4 ten sonra 6 karakteri getir demek

Console.ReadKey();
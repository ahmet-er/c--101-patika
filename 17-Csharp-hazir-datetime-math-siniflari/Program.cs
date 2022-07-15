// See https://aka.ms/new-console-template for more information

Console.WriteLine(DateTime.Now); // günün tarihini getirir
Console.WriteLine(DateTime.Now.Date);
Console.WriteLine(DateTime.Now.Day);
Console.WriteLine(DateTime.Now.Month);
Console.WriteLine(DateTime.Now.Year);
Console.WriteLine(DateTime.Now.Hour);
Console.WriteLine(DateTime.Now.Minute);
Console.WriteLine(DateTime.Now.Second);

Console.WriteLine("-------------------------------------------------------");
Console.WriteLine(DateTime.Now.DayOfWeek); // haftanın hangi gununde oldugunu doner
Console.WriteLine(DateTime.Now.DayOfYear); // icinde bulundugun yılın kacıncı gununde oldugunu doner
Console.WriteLine("-------------------------------------------------------");

Console.WriteLine(DateTime.Now.ToLongDateString());  // 15 Temmuz 2022 Cuma
Console.WriteLine(DateTime.Now.ToShortDateString()); // 15.07.2022
Console.WriteLine(DateTime.Now.ToLongTimeString());  // 09:27:40
Console.WriteLine(DateTime.Now.ToShortTimeString()); // 09:27
Console.WriteLine("-------------------------------------------------------");

Console.WriteLine(DateTime.Now.AddDays(2)); // DateTime.Now a Add...(x) zamanını ekler
Console.WriteLine(DateTime.Now.AddHours(3));    // DateTime.Now a Add...(x) zamanını ekler
Console.WriteLine(DateTime.Now.AddSeconds(30)); // DateTime.Now a Add...(x) zamanını ekler
Console.WriteLine(DateTime.Now.AddMonths(5));   // DateTime.Now a Add...(x) zamanını ekler
Console.WriteLine(DateTime.Now.AddYears(10));   // DateTime.Now a Add...(x) zamanını ekler
Console.WriteLine(DateTime.Now.AddMilliseconds(50));    // DateTime.Now a Add...(x) zamanını ekler
Console.WriteLine("-------------------------------------------------------");

// Datetime Format
Console.WriteLine(DateTime.Now.ToString("dd"));   // 15
Console.WriteLine(DateTime.Now.ToString("ddd"));  // Cum
Console.WriteLine(DateTime.Now.ToString("dddd")); // Cuma
 
Console.WriteLine(DateTime.Now.ToString("MM"));   // 07
Console.WriteLine(DateTime.Now.ToString("MMM"));  // Tem
Console.WriteLine(DateTime.Now.ToString("MMMM")); // Temmuz
 
Console.WriteLine(DateTime.Now.ToString("yy"));   // 22
Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2022

// Math Kütüphanesi
Console.WriteLine("-------------------Math Kütüphanesi--------------------");
Console.WriteLine(Math.Abs(-25)); // 25 = mutlak(absolute) alir
Console.WriteLine(Math.Sin(10));
Console.WriteLine(Math.Cos(10));
Console.WriteLine(Math.Tan(10));
Console.WriteLine("-------------------------------------------------------");

Console.WriteLine(Math.Ceiling(22.3)); // 23 - her zaman yukarı yuvarlar (Ceiling)
Console.WriteLine(Math.Round(22.3));   // 22 - asagı, yukarı yakın olma durumuna göre yuvarlar (Round)
Console.WriteLine(Math.Round(22.7));   // 23 
Console.WriteLine(Math.Floor(22.7));   // 22 - her zaman asagı yuvarlar (Floor)
Console.WriteLine("-------------------------------------------------------");

Console.WriteLine(Math.Max(2,6));
Console.WriteLine(Math.Min(2,6));
Console.WriteLine("-------------------------------------------------------");

Console.WriteLine(Math.Pow(3,4));  // 3^4 ü verir
Console.WriteLine(Math.Sqrt(9));   // 9 un karekokunu alır. 3
Console.WriteLine(Math.Log(9));    // 9 un e tabanındaki logaritmik karsıligi
Console.WriteLine(Math.Exp(3));    // e üzeri 3 verir
Console.WriteLine(Math.Log10(10)); // 10 sayısının logaritma 10 tabanındaki karsılıgını verir
Console.WriteLine("-------------------------------------------------------");

Console.ReadKey();
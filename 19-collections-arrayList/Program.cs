﻿// See https://aka.ms/new-console-template for more information

// System.Collections namespace
using System.Collections;

ArrayList liste = new ArrayList();

// liste.Add("Ayse");
// liste.Add(2);
// liste.Add(true);
// liste.Add('A');

// icerisinde verilere erisim
// Console.WriteLine(liste[1]);

foreach(var item in liste)
    Console.WriteLine(item);

// AddRange
Console.WriteLine("***** Add Range *****");
// string[] renkler = {"kırmızı", "sarı", "yesil"};
List<int> sayılar = new List<int>(){1,8,3,7,9,92,5};
//liste.AddRange(renkler);
liste.AddRange(sayılar);

foreach(var item in liste)
    Console.WriteLine(item);
Console.WriteLine("*********************");

// Sort
Console.WriteLine("***** Sort *****");
liste.Sort();

foreach(var item in liste)
    Console.WriteLine(item);

// Binary Search
Console.WriteLine("***** Binary Search *****");
Console.WriteLine(liste.BinarySearch(9));

// Reverse
Console.WriteLine("***** Reverse *****");
liste.Reverse();

foreach (var item in liste)
{
    Console.WriteLine(item);
}

// Clear
liste.Clear();

foreach (var item in liste)
{
    Console.WriteLine(item);
}













Console.ReadKey();
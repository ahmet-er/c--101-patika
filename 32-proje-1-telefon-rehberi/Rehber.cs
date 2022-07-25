using System;
namespace _32_proje_1_telefon_rehberi
{
    public class Rehber
    {
        List<Kisi> rehberListe = new List<Kisi>();
        public Rehber()//default atanan 5 li
        {
            Kisi kisi1 = new Kisi("mert", "gul", 45);
            rehberListe.Add(kisi1);
            Kisi kisi2 = new Kisi("derya", "ergul", 14);
            rehberListe.Add(kisi2);
            Kisi kisi3 = new Kisi("seray", "bes", 1434);
            rehberListe.Add(kisi3);
            Kisi kisi4 = new Kisi("buse", "cansız", 3254);
            rehberListe.Add(kisi4);
            Kisi kisi5 = new Kisi("fatih", "ozcan", 1414);
            rehberListe.Add(kisi5);
        }
        public void RehbereKaydet()//Kaydet
        {
            string isim, soyisim; int telNo;
            Console.Write("Lütfen isim giriniz             :"); isim = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz          :"); soyisim = Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz :"); telNo = Convert.ToInt32(Console.ReadLine());
            rehberListe.Add(new Kisi(isim, soyisim, telNo));
        }
        public void RehberdenSil()//Sil
        {
            string isimSil;
            int silmeyeDevam = 2;

            while (silmeyeDevam == 2)
            {
                Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
                isimSil = Console.ReadLine();
                foreach (var item in rehberListe)
                {
                    if ((rehberListe.IndexOf(item) == rehberListe.Count - 1) && !(isimSil.ToLower() == item.Isim.ToLower() || isimSil.ToLower() == item.Soyisim.ToLower()))
                    {
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        System.Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                        System.Console.WriteLine("* Yeniden denemek için      : (2)");
                        silmeyeDevam = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (isimSil.ToLower() == item.Isim.ToLower() || isimSil.ToLower() == item.Soyisim.ToLower())
                    {
                        Console.WriteLine(item.Isim + " " + item.Soyisim + " : " + item.TelNo + " kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");

                        if (Convert.ToChar(Console.ReadLine()) == 'y')
                        {
                            System.Console.WriteLine(item.Isim + " " + item.Soyisim + " : " + item.TelNo + " kişi silindi");
                            rehberListe.RemoveAt(rehberListe.IndexOf(item));
                            System.Console.WriteLine();
                            silmeyeDevam = 1;

                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }
        public void RehberiGuncelle()//Güncelle
        {
            string isimGuncelle;
            int guncellemeyeDevam = 2;

            while (guncellemeyeDevam == 2)
            {
                Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
                isimGuncelle = Console.ReadLine();
                foreach (var item in rehberListe)
                {
                    if ((rehberListe.IndexOf(item) == rehberListe.Count - 1) && !(isimGuncelle.ToLower() == item.Isim.ToLower() || isimGuncelle.ToLower() == item.Soyisim.ToLower()))
                    {
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        System.Console.WriteLine("* Güncellemeyi sonlandırmak için    : (1)");
                        System.Console.WriteLine("* Yeniden denemek için              : (2)");
                        guncellemeyeDevam = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (isimGuncelle.ToLower() == item.Isim.ToLower() || isimGuncelle.ToLower() == item.Soyisim.ToLower())
                    {
                        Console.WriteLine(item.Isim + " " + item.Soyisim + " : " + item.TelNo + " kişi bilgileri güncellenmek üzere, onaylıyor musunuz ?(y/n)");
                        if (Convert.ToChar(Console.ReadLine()) == 'y')
                        {
                            Console.Write("Lütfen güncel isim giriniz              : "); item.Isim = Console.ReadLine();
                            Console.Write("Lütfen güncel soyisim giriniz           : "); item.Soyisim = Console.ReadLine();
                            Console.Write("Lütfen güncel telefon numarası giriniz  : "); item.TelNo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(item.Isim + " " + item.Soyisim + " : " + item.TelNo + " kişi olarak güncellendi");
                            Console.WriteLine();
                            guncellemeyeDevam = 1;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                }

            }
        }
        public void RehberListele()//Listeleme
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("***************");
            int count = 1;
            foreach (var kisi in rehberListe)
            {
                Console.WriteLine(count + ". Kişi   :");
                Console.WriteLine("İsim      : {0}", kisi.Isim);
                Console.WriteLine("Soyisim   : {0}", kisi.Soyisim);
                Console.WriteLine("Telefon No: {0}", kisi.TelNo);
                Console.WriteLine("-"); count++;
            }
        }
        public void RehberdeArama()//Arama
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");

            int aramaTipi = Convert.ToInt32(Console.ReadLine());
            switch (aramaTipi)
            {
                case 1:
                    Console.Write("Arama yapilacak isim yada soyisim girin: ");
                    string isimAra = Console.ReadLine();
                    foreach (var item in rehberListe)
                    {
                        if ((rehberListe.IndexOf(item) == rehberListe.Count - 1) && !(isimAra.ToLower() == item.Isim.ToLower() || isimAra.ToLower() == item.Soyisim.ToLower()))
                        {
                            if (!rehberListe.Contains(item))
                            {
                                Console.WriteLine("Aradıgıniz kritere uygun veri rehberde bulunamadı!");
                            }
                        }
                        else if (isimAra.ToLower() == item.Isim.ToLower() || isimAra.ToLower() == item.Soyisim.ToLower())
                        {
                            Console.WriteLine(" İsim: " + item.Isim + "\n Soyisim: " + item.Soyisim + "\n Telefon Numarası: " + item.TelNo);
                        }
                    }

                    break;

                case 2:
                    Console.Write("Arama yapilacak telefon numarasını girin: ");
                    int telNoAra = Convert.ToInt32(Console.ReadLine());

                    foreach (var item in rehberListe)
                    {
                        if ((rehberListe.IndexOf(item) == rehberListe.Count - 1) && !(telNoAra == item.TelNo))
                        {
                            if (!rehberListe.Contains(item))
                                Console.WriteLine("Aradıgıniz kritere uygun veri rehberde bulunamadı!");
                        }
                        else if (telNoAra == item.TelNo)
                        {
                            System.Console.WriteLine(" İsim: " + item.Isim + "\n Soyisim: " + item.Soyisim + "\n Telefon Numarası: " + item.TelNo);
                        }
                    }

                    break;

                default:
                    Console.WriteLine("Hatali arama tipi girdiniz!");
                    break;
            }
        }
    }
}
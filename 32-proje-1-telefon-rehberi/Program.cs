using System;
namespace _32_proje_1_telefon_rehberi
{
    class Program
    {
        static void Main(string[] args)
        {
            Rehber rehber = new Rehber();

            bool cikis = false; // çıkış işlemi kapalı
            while (cikis != true)
            {
                Console.WriteLine("******************************************");
                Console.WriteLine("[1] Yeni Numara Kaydetmek");
                Console.WriteLine("[2] Varolan Numarayı Silmek");
                Console.WriteLine("[3] Varolan Numarayı Güncelleme");
                Console.WriteLine("[4] Rehberi Listelemek");
                Console.WriteLine("[5] Rehberde Arama Yapmak");
                Console.WriteLine("******************************************");

                int islemSecimi;

                Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz : ");
                islemSecimi = Convert.ToInt32(Console.ReadLine());
                switch (islemSecimi)
                {
                    case 1://Kayit
                        rehber.RehbereKaydet();
                        break;
                    case 2://Sil
                        rehber.RehberdenSil();
                        break;
                    case 3://Güncelle
                        rehber.RehberiGuncelle();
                        break;
                    case 4://Listeleme
                        rehber.RehberListele();
                        break;
                    case 5://Arama
                        rehber.RehberdeArama();
                        break;
                    default:
                        Console.Write("Geçerli bir işlem kodu girmediniz!");
                        break;
                }

                Console.Write("\n\nÇıkmak istiyormusunuz (E/H)");
                char cikmak = Convert.ToChar(Console.ReadLine());
                if (cikmak == 'e' || cikmak == 'E')
                {
                    cikis = true; return;
                }
                else
                {
                    cikis = false;
                }
            }

            Console.ReadKey();
        }
    }
}








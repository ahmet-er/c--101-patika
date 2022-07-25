using System;
namespace _32_proje_1_telefon_rehberi
{
    class Kisi
    {
        string isim;
        string soyisim;
        int telNo;


        public Kisi(string isim, string soyisim, int telNo)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.TelNo = telNo;
        }

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int TelNo { get => telNo; set => telNo = value; }
    }
}
using System;
using System.Runtime.CompilerServices;

namespace _33_proje_2_toDo_uygulamasi
{
    public class SelectionOperation
    {

        public static void ListBoard() // Butun Listeyi Goruntuleme
        {
            Console.WriteLine("\nTODO Line");
            Console.WriteLine("**********************");
            ListAll(Board.Line, "TODO");

            Console.WriteLine("\nIN PROGRESS Line");
            Console.WriteLine("**********************");
            ListAll(Board.Line, "IN PROGRESS");

            Console.WriteLine("\nDONE Line");
            Console.WriteLine("**********************");
            ListAll(Board.Line, "DONE");

            Menu.MenuUI();
        }

        public static void ListAll(List<Card> cards, string lines)// Listeyi Goruntuleme
        {
            foreach (var item in cards)
            {
                if (lines == item.Line)
                {
                    Console.WriteLine("\nBaşlık       : {0}", item.Title);
                    Console.WriteLine("İcerik       : {0}", item.Content);
                    Console.WriteLine("Atanan Kisi  : {0}", PersonInfo.person.Find(a => a.PersonId == item.PersonId).Name);
                    Console.WriteLine("Buyukluk     : {0}", ((EnumSize)item.Size).ToString());
                    Console.WriteLine("---");
                }
            }
        }

        public static void AddBoard()
        {
            Console.Write("\nBaslik Giriniz\t: ");
            string titleAdd = Console.ReadLine();
            Console.Write("\nİcerik Giriniz\t: ");
            string contentAdd = Console.ReadLine();
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5) :");
            int sizeAdd = int.Parse(Console.ReadLine());
            Console.Write("Kişi Seçiniz\t: ");
            int personidAdd = int.Parse(Console.ReadLine());

            if (PersonInfo.person.Find(a => a.PersonId == personidAdd).PersonId == personidAdd)// listede boyle bir kullanici varmi yok mu onun kontrolu
            {
                Board.Line.Add(new Card(titleAdd, contentAdd, personidAdd, sizeAdd, "TODO"));
            }
            else
            {
                Console.WriteLine("Hatali giris yaptiniz!");
            }
            Menu.MenuUI();
        }
        public static void RemoveBoard()
        {
            Console.WriteLine("\nOncelikle silmek istediginiz kartı secmeniz gerekiyor.");
            Console.Write("Lutfen kart basligini yaziniz: ");
            string titleBoard = (Console.ReadLine()).ToLower();
            var removeBoard = Board.Line.Where(x => x.Title.ToLower() == titleBoard).ToList(); // kullanicinin girdigi baslikla listede eklli olan baslik var mi bakiyor
            if (removeBoard.Count > 0)
            {
                for (int i = 0; i < removeBoard.Count; i++) // ayni basliktaki butun boardlari siliyor
                {
                    Board.Line.RemoveAll(x => x.Title.ToLower() == titleBoard);
                }
                Console.WriteLine("Silme islemi gerceklestirildi.");
                Menu.MenuUI();
            }
            else
            {
                NotFoundboard();
            }
        }
        public static void TransBoard()// Line Transferi
        {
            Console.WriteLine("\nOncelikle tasimak istediginiz karti secmeniz gerekiyor.");
            Console.Write("Lutfen kart basligini yaziniz: ");
            string titleBoard = (Console.ReadLine()).ToLower();
            var linqPerson = Board.Line.Where(x => x.Title.ToLower() == titleBoard).ToList();
            if (linqPerson.Count > 0)
            {
                TransBoardList(titleBoard);

                Console.WriteLine("Lutfen tasimak istediginiz Line'i seciniz: ");
                Console.WriteLine(" (1) TODO");
                Console.WriteLine(" (2) IN PROGRESS");
                Console.WriteLine(" (3) DONE");
                int selection = int.Parse(Console.ReadLine());
                if (selection == 1)
                {
                    linqPerson[0].Line = "TODO";
                    TransBoardList(titleBoard);
                }
                else if (selection == 2)
                {
                    linqPerson[0].Line = "IN PROGRESS";
                    TransBoardList(titleBoard);
                }
                else if (selection == 3)
                {
                    linqPerson[0].Line = "DONE";
                    TransBoardList(titleBoard);
                }
                else
                {
                    Console.WriteLine("Hatali bir secim yaptiniz!");
                }
                Menu.MenuUI();
            }
            else
            {
                NotFoundboard();
            }
        }
        public static void TransBoardList(string titleBoard)
        {
            var linqPerson = Board.Line.Where(x => x.Title.ToLower() == titleBoard).ToList();
            Console.WriteLine("\nBulunan Kart Bilgileri:");
            Console.WriteLine("********************************");
            Console.WriteLine("Baslik       : {0}", linqPerson[0].Title);
            Console.WriteLine("İcerik       : {0}", linqPerson[0].Content);
            Console.WriteLine("Atanan Kisi  : {0}", PersonInfo.person.Find(a => a.PersonId == linqPerson[0].PersonId).Name);
            Console.WriteLine("Buyukluk     : {0}", ((EnumSize)linqPerson[0].Size).ToString());
            Console.WriteLine("Line         : {0}", linqPerson[0].Line);
        }
        public static void NotFoundboard([CallerMemberName] string callermemberName = "")// silmek veya degistirmek istedigimiz baslik bulamayinca
        {
            Console.WriteLine("\nAradiginiz kriterlere uygun kart board'da bulunamadi. Kutfen bir secim yapiniz.");
            Console.WriteLine(" * Islemi Sonlandirmak Icin : (1).");
            Console.WriteLine(" * Yeniden Denemek Icin : (2).");
            int select = int.Parse(Console.ReadLine());
            if (select == 1)
            {
                Menu.MenuUI();
            }
            else if (select == 2)
            {
                if (callermemberName == "RemoveBoard")
                {
                    RemoveBoard();
                }
                else if (callermemberName == "Transboard")
                {
                    TransBoard();
                }
            }
            else
            {
                Console.WriteLine("Yanlis Secim Yaptiniz.");
                Menu.MenuUI();
            }
        }

    }
}
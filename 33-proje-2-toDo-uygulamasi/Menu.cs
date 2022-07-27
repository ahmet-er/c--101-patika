using System;
namespace _33_proje_2_toDo_uygulamasi
{
    public class Menu
    {
        public static void MenuUI()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz  :");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");

            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    SelectionOperation.ListBoard();
                    break;
                case 2:
                    SelectionOperation.AddBoard();
                    break;
                case 3:
                    SelectionOperation.RemoveBoard();
                    break;
                case 4:
                    SelectionOperation.TransBoard();
                    break;
                default:
                    Console.WriteLine("Hatali secim yaptiniz!");
                    Menu.MenuUI();
                    break;
            }
        }
    }
}
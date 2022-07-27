using System;
namespace _33_proje_2_toDo_uygulamasi
{
    public class Board
    {
        public static List<Card> Line = new List<Card>();

        public Board()
        {
            Line.Add(new Card("Mail", "Mailleri kontrol et", 1, 1, "TODO"));
            Line.Add(new Card("Kapı", "Kapıyı kapat", 2, 2, "IN PROGRESS"));
            Line.Add(new Card("Su", "Su iç", 3, 3, "DONE"));
            Line.Add(new Card("Yemek", "Yemek ye", 4, 4, "DONE"));
        }
    }
}
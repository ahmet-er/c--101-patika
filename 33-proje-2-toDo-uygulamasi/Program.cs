using System;
namespace _33_proje_2_toDo_uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            PersonInfo personInfo = new PersonInfo();

            Menu.MenuUI();
            
            Console.ReadKey();
        }
    }
}
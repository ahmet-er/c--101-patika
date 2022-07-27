using System;
namespace _33_proje_2_toDo_uygulamasi
{
    public class Card
    {
        private string title;
        private string content;
        private int personId;
        private int size;
        private string line;
        public Card(string title, string content, int personId, int size, string line)
        {
            this.Title = title;
            this.Content = content;
            this.PersonId = personId;
            this.Size = size;
            this.Line = line;
        }

        public string Line { get => line; set => line = value; }
        public int Size { get => size; set => size = value; }
        public int PersonId { get => personId; set => personId = value; }
        public string Content { get => content; set => content = value; }
        public string Title { get => title; set => title = value; }
    }
}

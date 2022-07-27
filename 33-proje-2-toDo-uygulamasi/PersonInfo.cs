using System;
namespace _33_proje_2_toDo_uygulamasi
{
    public class PersonInfo
    {
        public static List<Person> person = new List<Person>();

        public PersonInfo()
        {
            person.Add(new Person(1, "Ahmet Er"));
            person.Add(new Person(2, "Fatih Ozcan"));
            person.Add(new Person(3, "Mert Gul"));
            person.Add(new Person(4, "Faber  Castell"));
        }
    }
}
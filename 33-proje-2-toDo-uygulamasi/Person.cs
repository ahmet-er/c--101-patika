using System;
namespace _33_proje_2_toDo_uygulamasi
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }

        public Person(int personId, string name)
        {
            PersonId = personId;
            Name = name;

        }
    }
}
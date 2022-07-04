using System;

namespace ToDo_App {

    public class Person {
        public int PersonId {get; set;}
        public string Name {get; set;}


        public Person(int personId, string name)
        {
            PersonId = personId;
            Name = name;
        }
    }
}
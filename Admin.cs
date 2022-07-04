using System;

namespace ToDo_App{
    public class PersonInfo{
        public static List<Person> person = new List<Person>();

        public PersonInfo(){
            person.Add(new Person(1,"Yavuz Eroğlu"));
            person.Add(new Person(2,"Cemil Hakkı"));
            person.Add(new Person(3,"Emircan Şentürk"));
            person.Add(new Person(4,"Fatma Kuş"));
            
        }
    }
}
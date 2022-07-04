using System;

namespace ToDo_App {
    public class Board{
        public static List<Card> Line = new List<Card>();


        public Board(){
            Line.Add(new Card("Odev","Net Core Patikaları Bitecek",1,1,"IN PROGRESS"));
            Line.Add(new Card("Proje","Büyük ölçekli bir proje yapılacak",2,2,"TODO"));
            Line.Add(new Card("Spor","Günlük Egzersizlerinizi unutmayın",3,3,"DONE"));

        }

    }

    
}
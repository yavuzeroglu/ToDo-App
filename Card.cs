using System;

namespace ToDo_App {
    public class Card {
        private string baslik;
        private string icerik;
         private int PersonId;
        private int buyukluk;

        private string status;




        public string Baslik { get => baslik; set => baslik = value; }

        public string İcerik { get => icerik; set => icerik = value; }
        
        public int Buyukluk { get => buyukluk; set => buyukluk = value; }
        public int PersonId1 { get => PersonId; set => PersonId = value; }
        public string Status { get => status; set => status = value; }

        public Card(string baslik, string icerik, int personId1, int buyukluk, string status)
        {
            Baslik = baslik;
            İcerik = icerik;
            PersonId1 = personId1;
            Buyukluk = buyukluk;
            Status = status;
        }
    }
}
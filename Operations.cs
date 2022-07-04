using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ToDo_App
{
    public class Operations
    {
        //Listeyi Görüntüleme
        public static void ListBoard(){
            Console.WriteLine("TODO Line");
            Console.WriteLine("**********");
            ListAll(Board.Line,"TODO");
        }
        public static void ListAll(List<Card> cards, string lines){
            foreach (var item in cards)
            {
                if(lines == item.Status){
                    Console.WriteLine("Başlık : "+item.Baslik);
                    Console.WriteLine("İçerik :"+item.İcerik);
                    Console.WriteLine("Atanan Kişi :"+PersonInfo.person.Find(a => a.PersonId == item.PersonId1).Name);
                    Console.WriteLine("Büyüklük :"+((enumSize)item.Buyukluk).ToString());
                    Console.WriteLine("-");
                }
            }
        }

        public static void AddBoard()
        {
            Console.WriteLine("Başlık Giriniz :");
            string titleAdd = Console.ReadLine();
            Console.WriteLine("İçerik Giriniz :");
            string contentAdd = Console.ReadLine();
            Console.WriteLine("Büyüklük Seçiniz => XS(1),S(2),M(3),L(4),XL(5) :");
            int sizeAdd = int.Parse(Console.ReadLine());
            Console.WriteLine("Kişi seçiniz :");
            int personidAdd = int.Parse(Console.ReadLine());

            if(PersonInfo.person.Find(a=>a.PersonId==personidAdd).PersonId == personidAdd){
                Board.Line.Add(new Card(titleAdd,contentAdd,personidAdd,sizeAdd,"TODO"));
            }
            else 
                Console.WriteLine("Hatalı Giriş Yapıldı!");

            Menu.MenuUI();    


        }

        public static void RemoveBoard(){
            Console.WriteLine(" Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız:  ");
            string titleBoard =(Console.ReadLine()).ToLower();
            var RemoveBoard = Board.Line.Where(x => x.Baslik.ToLower()== titleBoard).ToList();
            if(RemoveBoard.Count>0)
            {
                for(int i = 0; i<RemoveBoard.Count;i++)
                {
                    Board.Line.RemoveAll(x => x.Baslik.ToLower()==titleBoard.ToLower());
                }
                Console.WriteLine("Silme işlemi Gerçekleştirildi...");
                Menu.MenuUI();
            }
            else{
                NotFoundBoard();
            }

        }
        public static void TransBoard()
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.WriteLine("Lütfen kart başlığını yazınız :");
            string titleBoard = (Console.ReadLine()).ToLower();
            var linqPerson = Board.Line.Where(x=> x.Baslik.ToLower() == titleBoard).ToList();
            if(linqPerson.Count>0){
                TransBoardList(titleBoard);

                Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: ");
                Console.WriteLine(" (1) TODO");
                Console.WriteLine(" (2) IN PROGRESS");
                Console.WriteLine(" (3) DONE");
                int temp = int.Parse(Console.ReadLine());
                if(temp == 1)
                {
                    linqPerson[0].Status = "TODO";
                    TransBoardList(titleBoard);
                }
                else if(temp ==2) 
                {
                    linqPerson[0].Status="IN PROGRESS";
                    TransBoardList(titleBoard);
                }
                else if(temp == 3)
                {
                    linqPerson[0].Status = "DONE";
                    TransBoardList(titleBoard);
                }
                else 
                    Console.WriteLine("Hatalı bir seçim yaptınız");
                Menu.MenuUI();
            }
            else {
                NotFoundBoard();
            }

        }

        public static void TransBoardList(string titleBoard)
        {
            var linqPerson = Board.Line.Where(x => x.Baslik.ToLower()==titleBoard).ToList();
            Console.WriteLine("Bulunan Kart Bilgileri :");
            Console.WriteLine("**************************");
            Console.WriteLine("Baslik :"+linqPerson[0].Baslik);
            Console.WriteLine("İçerik :"+linqPerson[0].İcerik);
            Console.WriteLine("Atanan Kişi :"+PersonInfo.person.Find(a => a.PersonId == linqPerson[0].PersonId1).Name);
            Console.WriteLine("Büyüklük :"+((enumSize)linqPerson[0].Buyukluk).ToString());
            Console.WriteLine("Line :"+linqPerson[0].Status);
        }

        public static void NotFoundBoard([CallerMemberName] string callermembername = "")
        {
            Console.WriteLine("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
            Console.WriteLine("İşlemi sonlandırmak için : (1)");
            Console.WriteLine("Yeniden denemek için : (2)");
            int temp = int.Parse(Console.ReadLine());
            if(temp == 1)
                Menu.MenuUI();
            else if (temp == 2){
                if(callermembername == "RemoveBoard")
                {
                    RemoveBoard();
                }
                else if (callermembername == "TransBoard")
                {
                    TransBoard();
                }
            }
            else
            {
                Console.WriteLine("Yanlış seçim yaptınız.");
                Menu.MenuUI();
            }    
        } 
    }

    
}
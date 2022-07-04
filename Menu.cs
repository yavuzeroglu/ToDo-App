using System;
using System.Collections.Generic;


namespace ToDo_App
{
    public class Menu 
    {
        public static void MenuUI()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz : \n" +
                "*******************************************\n"+
                "(1) Board Listelemek\n"+
                "(2) Board'a Kart Eklemek \n"+
                "(3) Board'dan Kart Silmek\n"+
                "(4) Kart Taşımak\n");
                
                int inputSelect = int.Parse(Console.ReadLine());

                switch (inputSelect)
                {
                    case 1: 
                        Operations.ListBoard();
                        break;
                    case 2:
                        Operations.AddBoard();
                        break;
                    case 3:
                        Operations.RemoveBoard();
                        break;
                    case 4:
                        Operations.TransBoard();
                        break;
                    default:
                        Console.WriteLine("Hatalı seçim yaptınız.");
                        Menu.MenuUI();
                        break;    
                }
        }
    }
}
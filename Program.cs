using System;

namespace ToDo_App 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            PersonInfo personInfo = new PersonInfo();

            Menu.MenuUI();

        }
    }
}
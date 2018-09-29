using System;

namespace Workshop2Design
{
    class MainUI
    {
        private int menuChoice = 0;

        public int MenuChoice{
            get{ return menuChoice; }
            set{ 
                if(value < 0 || value > 5){
                    throw new ArgumentOutOfRangeException("Your choice needs to be 1-4");
                } else {
                    menuChoice = value;
                }
             }
        }

        public MainUI(){
            renderMainUI();
        }
        private void renderMainUI(){
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔═════════════════════════════════════════╗ ");
            Console.WriteLine(" ║     The Jolly Pirates Member System     ║ ");
            Console.WriteLine(" ╚═════════════════════════════════════════╝ ");
            Console.BackgroundColor = ConsoleColor.Black;
            readMenuChoice();
        }

        private void readMenuChoice(){
            Console.WriteLine("What would you like to do?:");
            MenuChoice = int.Parse(Console.ReadLine());
        }
    }
}

using System;

namespace Workshop2Design
{
    class MainView
    {
        private int menuChoice = 0;

        public int MenuChoice
        {
            get{ return menuChoice; }
            set{ 
                if(value < 0 || value > 5){
                    throw new ArgumentOutOfRangeException("Your choice needs to be 1-4");
                } else {
                    menuChoice = value;
                }
             }
        }

        public MainView()
        {
            renderMainUI();
        }
        private void renderMainUI()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔═════════════════════════════════════════╗ ");
            Console.WriteLine(" ║     The Jolly Pirates Member System     ║ ");
            Console.WriteLine(" ╚═════════════════════════════════════════╝ ");
            Console.WriteLine(" 1. Add a new member                         ");
            Console.BackgroundColor = ConsoleColor.Black;
            readMenuChoice();
        }

        private void readMenuChoice()
        {
            Console.WriteLine("What would you like to do?:");
            MenuChoice = int.Parse(Console.ReadLine());
        }

        /* public char ContinueOnKeyPressed()
        {
            char yesOrNo;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("\n Do you want to try again Y/N:");
            Console.ResetColor();
            Console.CursorVisible = false;
            yesOrNo = char.Parse(Console.ReadLine());
            Console.Clear();
            Console.CursorVisible = true;
            return yesOrNo;
        }*/
    }
}

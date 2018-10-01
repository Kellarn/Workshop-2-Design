using System;

namespace Workshop2Design
{
    class MainView
    {
        private int menuChoice = 1;

        public int MenuChoice
        {
            get{ return menuChoice; }
            set{ 
                if(value < 0 || value > 2){
                    throw new ArgumentOutOfRangeException("Your choice needs to be 0-2");
                } else {
                    menuChoice = value;
                }
             }
        }

        public MainView()
        {
            // renderMainUI();
        }
        public void renderMainUI()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔═════════════════════════════════════════╗ ");
            Console.WriteLine(" ║     The Jolly Pirates Member System     ║ ");
            Console.WriteLine(" ╚═════════════════════════════════════════╝ ");
            Console.WriteLine(" 1. Add a new member                         ");
            Console.WriteLine(" 2. List all members                         ");
            Console.WriteLine(" 0. Exit application                         ");
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
        public void ExitMessage(){
            Console.WriteLine("Bye Bye!");
        }
        public void DisplayError(Exception ex)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n" + ex.Message);
            Console.WriteLine("Press any key to try again!");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
        }
    }
}

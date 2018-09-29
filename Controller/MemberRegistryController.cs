using System;

namespace Workshop2Design
{
    class MemberRegistryController
    {
        private MainView mainView;

        private CreateMemberView createMemberView;
        private int menuChoice;
        public MemberRegistryController()
        {
            RunApplication();
        }

        private void RunApplication()
        {
            try
            {
                mainView = new MainView();
                menuChoice = mainView.MenuChoice;

                switch(menuChoice)
                {
                    case 1:
                    createMemberView = new CreateMemberView();
                    break;

                    default:
                    Console.WriteLine("Not yet implemented");
                    break;
                }
                // Console.WriteLine(menuChoice);
            }
            catch (Exception ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Error.WriteLine("\n" + ex.Message);
                
            }
            /* char yesOrNo = mainView.ContinueOnKeyPressed();
            if(yesOrNo == 'Y' || yesOrNo == 'y')
            {
                RunApplication();
            }
            else
            {

            }*/
        }
    }
}

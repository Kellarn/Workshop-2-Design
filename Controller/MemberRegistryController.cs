using System;

namespace Workshop2Design
{
    class MemberRegistryController
    {

        private CreateUser createUser;
        private MainUI mainUI;
        private int menuChoice;
        public MemberRegistryController()
        {
            createUser = new CreateUser();
            mainUI = new MainUI();
            menuChoice = mainUI.MenuChoice;
            Console.WriteLine(menuChoice);
        }
    }
}

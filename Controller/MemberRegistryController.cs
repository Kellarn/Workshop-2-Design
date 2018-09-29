using System;

namespace Workshop2Design
{
    class MemberRegistryController
    {
        private MainView mainView;
        private CreateMemberView createMemberView;
        private CreateMember createMember;
        private int menuChoice;
        public MemberRegistryController()
        {
            RunApplication();
        }

        private void RunApplication()
        {
            mainView = new MainView();
            createMember = new CreateMember();
            menuChoice = mainView.MenuChoice;

            while (menuChoice != 0)
            {
                mainView.renderMainUI();
                menuChoice = mainView.MenuChoice;
                switch (menuChoice)
                {
                    case 1:
                        createMemberView = new CreateMemberView();
                        createMember.addNewMember(createMemberView.Name, createMemberView.PersonalNumber);
                        break;

                    case 2:
                        break;
                    default:
                        createMember.writeToJSON();
                        mainView.ExitMessage();
                        break;
                }
            }
        }
    }
}

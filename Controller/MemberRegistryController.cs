using System;

namespace Workshop2Design
{
    class MemberRegistryController
    {
        private MainView mainView;
        private CreateMemberView createMemberView;
        private ListMembersView listMembersView;
        private CRUDMember crudMember;
        private int menuChoice;
        public MemberRegistryController()
        {
            RunApplication();
        }

        private void RunApplication()
        {
            mainView = new MainView();
            crudMember = new CRUDMember();
            menuChoice = mainView.MenuChoice;

            while (menuChoice != 0)
            {
                mainView.renderMainUI();
                menuChoice = mainView.MenuChoice;
                switch (menuChoice)
                {
                    case 1:
                        createMemberView = new CreateMemberView();
                        crudMember.addNewMember(createMemberView.Name, createMemberView.PersonalNumber);
                        break;

                    case 2:
                        listMembersView = new ListMembersView();
                        listMembersView.renderList(crudMember.Members);
                        break;
                    default:
                        crudMember.writeToJSON();
                        mainView.ExitMessage();
                        break;
                }
            }
        }
    }
}

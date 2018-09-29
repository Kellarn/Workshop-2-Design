using System;

namespace Workshop2Design
{
    class MemberRegistryController
    {
        private MainView mainView;
        private CreateMemberView createMemberView;
        private Member member;
        private CreateMember createMember;
        private int menuChoice;
        public MemberRegistryController()
        {
            RunApplication();
        }

        private void RunApplication()
        {
                mainView = new MainView();
                menuChoice = mainView.MenuChoice;

                switch(menuChoice)
                {
                    case 1:
                    createMemberView = new CreateMemberView();
                    createMember = new CreateMember();
                    member = new Member(createMemberView.Name, createMemberView.PersonalNumber);
                    createMember.addNewMember(member.Name, member.PersonalNumber);
                    break;

                    default:
                    Console.WriteLine("Not yet implemented");
                    break;
                }
                // Console.WriteLine(menuChoice);
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

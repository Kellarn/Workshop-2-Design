using System;

namespace Workshop2Design
{
    class MemberRegistryController
    {
        private MainView mainView;
        private CreateMemberView createMemberView;
        private ListMembersView listMembersView;
        private CRUDMember crudMember;
        private ActionOnMemberView actionOnMemberView;
        private BoatView boatView;
        private int menuChoice;
        private int memberChoice;
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
                        memberChoice = listMembersView.MemberChoice;
                        if (memberChoice == 0)
                        {
                            break;
                        }
                        else
                        {
                            Member selectedMember = listMembersView.listAndReturnSingelMember(crudMember.Members);
                            actionOnMemberView = new ActionOnMemberView();
                            // actionOnMemberSwitch(actionOnMemberView.ActionChoice, selectedMember);
                            boatView = new BoatView();
                            if (actionOnMemberView.ActionChoice == 1)
                            {
                                boatView.GetBoatInformation();
                                int boatCount = selectedMember.Boats.Count;
                                selectedMember.Boats.Add(new Boat(boatView.BoatType, boatView.Length, boatCount + 1));

                                //Should this be made into a method in the member class to increase number of boats?
                                selectedMember.NumberOfBoats += 1;
                            } 
                            else if(actionOnMemberView.ActionChoice == 2)
                            {
                                boatView.whichBoatToChange(selectedMember.Boats);
                                boatView.GetBoatInformation();
                                selectedMember.selectAndUpdateBoat(boatView.BoatChoice, boatView.BoatType, boatView.Length);
                                // int boatCount = selectedMember.Boats.Count;
                            }
                            break;
                        }
                    default:
                        crudMember.writeToJSON();
                        mainView.ExitMessage();
                        break;
                }
            }
        }

        /*private void actionOnMemberSwitch(int choice, Member selectedMember)
        {
            while (choice != 0)
            {
                switch (choice)
                {
                    case 1:
                        boatView = new BoatView();
                        selectedMember.Boats.Add(new Boat(boatView.BoatType, boatView.Length));
                        selectedMember.NumberOfBoats += 1;
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    default:
                        break;
                }
            }
        }*/
    }
}

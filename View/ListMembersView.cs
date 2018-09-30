using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Workshop2Design
{
    class ListMembersView
    {
        private int listChoice;
        private int memberChoice;
        public ListMembersView()
        {
            ChooseHowToListMembers();
        }

        public int ListChoice
        {
            get { return listChoice; }
            set
            {
                if (value <= 0 || value > 2)
                {
                    throw new ArgumentOutOfRangeException("Your choice needs to be 1 or 2");
                }
                else
                {
                    listChoice = value;
                }
            }
        }
        public int MemberChoice
        {
            get { return memberChoice; }
            set { memberChoice = value; }
        }
        private void ChooseHowToListMembers()
        {
            Console.WriteLine("Which list do you want to view?");
            Console.WriteLine("1. Simple list.");
            Console.WriteLine("2. Detailed list.");
            listChoice = int.Parse(Console.ReadLine());

        }

        public void renderList(List<Member> members)
        {
            if (listChoice == 1)
            {
                foreach (Member member in members)
                {
                    // TODO Perhaps add a toString render method to the member class for cleaner output?
                    Console.WriteLine("Name: {0}", member.Name);
                    Console.WriteLine("ID: {0}", member.UniqueId);
                    Console.WriteLine("Number of boats: {0}", member.NumberOfBoats);
                }
            }
            else
            {
                foreach (Member member in members)
                {

                    // TODO Perhaps add a toString render method to the member class for cleaner output?
                    Console.WriteLine("\n***********************");
                    Console.WriteLine("* Name: {0}", member.Name);
                    Console.WriteLine("* Personal number: {0}", member.PersonalNumber);
                    Console.WriteLine("* ID: {0}", member.UniqueId);
                    Console.WriteLine("* Number of boats: {0}", member.NumberOfBoats);
                    foreach (Boat boat in member.Boats)
                    {
                        Console.WriteLine("Boat type: {0}", boat.BoatType);
                        Console.WriteLine("Length of boat: {0}", boat.Length);
                    }
                    Console.WriteLine("***********************");
                }
            }
            selectMemberForAction();
        }

        public void selectMemberForAction()
        {
            Console.WriteLine("Please enter the ID of the member you want to select for action:");
            Console.WriteLine("Press 0 to go back to main menu.");
            memberChoice = int.Parse(Console.ReadLine());
        }

        public Member listAndReturnSingelMember(List<Member> members)
        {
            Member selectedMember = members.FirstOrDefault(member => member.UniqueId == memberChoice);
            if(selectedMember == null)
            {
                throw new NullReferenceException("No member with selected ID exists, try again!");
            }

            //POSSIBLE REFACTORING - Create a function for displaying a member that can be used both here and in the renderList and not just copy the writelines here.
            Console.WriteLine("\n***********************");
            Console.WriteLine("* Name: {0}", selectedMember.Name);
            Console.WriteLine("* Personal number: {0}", selectedMember.PersonalNumber);
            Console.WriteLine("* ID: {0}", selectedMember.UniqueId);
            Console.WriteLine("* Number of boats: {0}", selectedMember.NumberOfBoats);
            if (selectedMember.NumberOfBoats != 0)
            {
                foreach (Boat boat in selectedMember.Boats)
                {
                    Console.WriteLine("Boat type: {0}", boat.BoatType);
                    Console.WriteLine("Length of boat: {0}", boat.Length);
                }
            }
            Console.WriteLine("***********************");
            return selectedMember;
        }
    }
}

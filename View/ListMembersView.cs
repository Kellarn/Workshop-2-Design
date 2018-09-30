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
        private void ChooseHowToListMembers()
        {
            Console.WriteLine("Which list do you want to view?");
            Console.WriteLine("1. Compact list.");
            Console.WriteLine("2. Verbose list.");
            listChoice = int.Parse(Console.ReadLine());

        }

        public void renderList(List<Member> members)
        {
            if (listChoice == 1)
            {
                foreach (Member member in members)
                {
                    Console.WriteLine("Name: {0}", member.Name);
                    Console.WriteLine("ID: {0}", member.UniqueId);
                }
            }
            else
            {
                foreach (Member member in members)
                {
                    Console.WriteLine("\n***********************");
                    Console.WriteLine("* Name: {0}", member.Name);
                    Console.WriteLine("* Personal number: {0}", member.PersonalNumber);
                    Console.WriteLine("* ID: {0}", member.UniqueId);
                    Console.WriteLine("***********************");
                }
            }
            Console.WriteLine("Press a key to go back to menu!");
            Console.ReadLine();
        }
    }
}

using System;

namespace Workshop2Design
{
    class CreateMemberView
    {
        private string name;
        private string personalNumber;
        public CreateMemberView()
        {
            GetMemberInformation();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string PersonalNumber{
            get { return personalNumber; }
            set { personalNumber = value; }
        }

        private void GetMemberInformation()
        {
            Console.WriteLine("Please enter the full name of the member:");
            Name = Console.ReadLine();

            Console.WriteLine("Please enter a personal number of the member:");
            PersonalNumber = Console.ReadLine();
        }

    }
}

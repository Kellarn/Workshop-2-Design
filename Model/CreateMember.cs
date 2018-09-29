using System;

namespace Workshop2Design
{
    class CreateMember
    {
        private string name;
        private string personalNumber;
        private int uniqueId;

        public CreateMember()
        {
            
        }

        private string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string PersonalNumber
        {
            get { return personalNumber; }
            set { personalNumber = value; }
        }
    }
}

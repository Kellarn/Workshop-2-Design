using System;
using Newtonsoft.Json; 
using Newtonsoft.Json.Linq; 
using System.Collections.Generic; 
using System.IO; 
using System.Linq; 
using System.Text; 

namespace Workshop2Design
{
    class Member
    {
        private string name;
        private string personalNumber;
        private int uniqueId;
        private List<Boat> Boats = new List<Boat>();


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string PersonalNumber
        {
            get { return personalNumber; }
            set { personalNumber = value; }
        }

        public int UniqueId
        {
            get { return uniqueId; }
            set { uniqueId = value; }
        }

        public Member()
        {
            name = "";
            personalNumber = "";
            uniqueId = 1;
        }
        public Member(string name, string personalNumber, int uniqueId)
        {
            Name = name;
            PersonalNumber = personalNumber;
            UniqueId = uniqueId;
        }
    }
}

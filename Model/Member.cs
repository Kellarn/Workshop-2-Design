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
        private int numberOfBoats;
        private List<Boat> boats = new List<Boat>();


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

        public int NumberOfBoats
        {
            get { return numberOfBoats; }
            set { numberOfBoats = value; }
        }
        public List<Boat> Boats
        {
            get { return boats; }
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
            NumberOfBoats = Boats.Count;
        }

        public void addBoat(Boat boat){
            boats.Add(boat);
        }

        public void selectAndUpdateBoat(int boatChoice, BoatType boatType, string length)
        {
            Boat boat = boats.FirstOrDefault(x => x.BoatID == boatChoice);
            if(boat != null)
            {
                boat.BoatType = boatType;
                boat.Length = length;
            }
        }
        public void deleteBoat(int boatChoice)
        {
            Boat boat = boats.FirstOrDefault(x => x.BoatID == boatChoice);
            if(boat != null)
            {
                boats.Remove(boat);
            }
        }
    }
}

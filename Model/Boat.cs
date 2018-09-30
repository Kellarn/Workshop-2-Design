using System;
using Newtonsoft.Json; 
using Newtonsoft.Json.Linq; 
using System.Collections.Generic; 
using System.IO; 
using System.Linq; 
using System.Text; 

namespace Workshop2Design
{
    class Boat
    {
        private BoatType boatType;

        private string length;

        private int boatID;

        public BoatType BoatType
        {
            get { return boatType; }
            set { boatType = value; }
        }

        public string Length
        {
            get { return length; }
            set { length = value; }
        }
        public int BoatID
        {
            get { return boatID; }
            set { boatID = value; }
        }
        public Boat()
        {
        }
        public Boat(BoatType boatType, string length, int boatID)
        {
            BoatType = boatType;
            Length = length;
            BoatID = boatID;
        }
    }
}

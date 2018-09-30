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

        public Boat()
        {
        }
        public Boat(BoatType boatType, string length)
        {
            BoatType = boatType;
            Length = length;
        }
    }
}

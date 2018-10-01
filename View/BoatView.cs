using System;
using System.Collections.Generic;

namespace Workshop2Design
{
    class BoatView
    {
        private BoatType boatType;
        private string length;
        private int boatChoice;
        private int boatTypeChoice;
        public BoatView()
        {
            // GetBoatInformation();
        }
        public int BoatTypeChoice
        {
            get { return boatTypeChoice; }
            set { boatTypeChoice = value; }
        }
        public BoatType BoatType
        {
            get { return boatType; }
            set { boatType = value; }
        }

        public string Length{
            get { return length; }
            set { length = value; }
        }

         public int BoatChoice{
            get { return boatChoice; }
            set { boatChoice = value; }
        }

        public void GetBoatInformation()
        {
            Console.WriteLine("Please enter the type of boat");
            var values = Enum.GetValues(typeof(BoatType));
            foreach(BoatType boatType in values)
            {
                Console.WriteLine("{0}. {1}", (int)boatType, boatType);
            }
            BoatTypeChoice = int.Parse(Console.ReadLine());
            BoatType = (BoatType)BoatTypeChoice;

            Console.WriteLine("Please enter a the length of the boat:");
            Length = Console.ReadLine();
        }

        public void whichBoatToChange(List<Boat> boats)
        {
            Console.WriteLine("Which boat do you want to update?:");
            foreach(Boat boat in boats)
            {
                Console.WriteLine("{0}. {1}", boat.BoatID, boat.BoatType);
            }
            BoatChoice = int.Parse(Console.ReadLine());
        }
    }
}

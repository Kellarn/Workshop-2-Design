using System;

namespace Workshop2Design
{
    class BoatView
    {
        private BoatType boatType;
        private string length;
        private int boatChoice;
        public BoatView()
        {
            GetBoatInformation();
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

        private void GetBoatInformation()
        {
            Console.WriteLine("Please enter the type of boat");
            var values = Enum.GetValues(typeof(BoatType));
            foreach(BoatType boatType in values)
            {
                Console.WriteLine("{0}. {1}", (int)boatType, boatType);
            }
            BoatChoice = int.Parse(Console.ReadLine());
            BoatType = (BoatType)BoatChoice;

            Console.WriteLine("Please enter a the length of the boat:");
            Length = Console.ReadLine();
        }
    }
}

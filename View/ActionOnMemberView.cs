using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Workshop2Design
{

    class ActionOnMemberView
    {
         private int actionChoice;

         public int ActionChoice
         {
             get { return actionChoice; }
             set {
                 if(value > 5)
                 {
                     throw new ArgumentOutOfRangeException("Your choice needs to be 1-5");
                 } else {
                     actionChoice = value;
                 }
             }
         }

         public ActionOnMemberView()
         {
             chooseAction();
         }

         public void chooseAction()
         {
            Console.WriteLine("Which action do you want to perform?");
            Console.WriteLine("1. Add boat");
            Console.WriteLine("2. Update existing boat");
            Console.WriteLine("3. Delete a boat");
            Console.WriteLine("4. Change member information");
            Console.WriteLine("5. Delete member");
            
            ActionChoice = int.Parse(Console.ReadLine());
         }
    }
}
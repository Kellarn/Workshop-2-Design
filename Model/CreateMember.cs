using System;
using Newtonsoft.Json; 
using Newtonsoft.Json.Linq; 
using System.Collections.Generic; 
using System.IO; 
using System.Linq; 
using System.Text; 

namespace Workshop2Design
{
    class CreateMember
    {
        private string jsonFile = @"users.json";
        private int currentIdNumber = 1;
        private List<Member> _members = new List<Member>();

        public CreateMember()
        {
            readJSONAndPopulateList();
            findAndUpdateUniqueId();
        }
        public void addNewMember(string name, string personalNumber)
        {
            currentIdNumber += 1;
            _members.Add(new Member(name, personalNumber, currentIdNumber));
        }
        private void findAndUpdateUniqueId()
        {
            object lastObject = _members.Last();
            object lastId = lastObject.GetType().GetProperty("UniqueId").GetValue(lastObject, null);
            currentIdNumber = (int) lastId;
        }

        private void readJSONAndPopulateList()
        {
            string json = File.ReadAllText(jsonFile);
            _members = JsonConvert.DeserializeObject<List<Member>>(json);
        }

        public void writeToJSON()
        {
            File.WriteAllText(@jsonFile, JsonConvert.SerializeObject(_members, Formatting.Indented));
        }
    }
}

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
        private List<Member> _member = new List<Member>();

        public void addNewMember(string name, string personalNumber)
        {
            string json = File.ReadAllText(jsonFile);
            _member = JsonConvert.DeserializeObject<List<Member>>(json);
            _member.Add(new Member(name, personalNumber));
            File.WriteAllText(@jsonFile, JsonConvert.SerializeObject(_member, Formatting.Indented));
            /* var list = JsonConvert.DeserializeObject<List<Member>>(jsonFile);
            list.Add(new Member(name, personalNumber));
            var convertedJson = JsonConvert.SerializeObject(list, Formatting.Indented);
            Console.WriteLine(convertedJson);
            newMember = "{'Name:':" + Name + ", 'PersonalNumber:'" + PersonalNumber + "'}"; */
            
        }
    }
}

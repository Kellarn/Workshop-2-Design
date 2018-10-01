using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Workshop2Design
{
    class CRUDMember
    {
        private string jsonFile = @"users.json";
        private int currentIdNumber = 0;
        private List<Member> members = new List<Member>();

        public List<Member> Members
        {
            get { return members; }
        }

        public CRUDMember()
        {
            readJSONAndPopulateList();
            findAndUpdateUniqueId();
        }
        public void addNewMember(string name, string personalNumber)
        {
            currentIdNumber += 1;
            members.Add(new Member(name, personalNumber, currentIdNumber));
        }
        private void findAndUpdateUniqueId()
        {
            if (members.Any())
            {
                object lastObject = members.Last();
                object lastId = lastObject.GetType().GetProperty("UniqueId").GetValue(lastObject, null);
                currentIdNumber = (int)lastId;
            }
        }

        private void readJSONAndPopulateList()
        {
            string json = File.ReadAllText(jsonFile);
            members = JsonConvert.DeserializeObject<List<Member>>(json);
        }

        public void writeToJSON()
        {
            File.WriteAllText(@jsonFile, JsonConvert.SerializeObject(members, Formatting.Indented));
        }

        public void updateMemberInformation(int memberID, string newName, string newPersonalNumber)
        {
            Member member = members.FirstOrDefault(x => x.UniqueId == memberID);
            if (member != null)
            {
                member.Name = newName;
                member.PersonalNumber = newPersonalNumber;
            }
        }

        public void deleteMember(int memberID){
            Member member = members.FirstOrDefault(x => x.UniqueId == memberID);
            if(member != null)
            {
                members.Remove(member);
            }
        }
    }
}

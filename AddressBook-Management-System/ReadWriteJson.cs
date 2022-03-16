using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Management_System
{
    class ReadWriteJson
    {
        string filePath = @"C:\Users\shashiRgowda\Desktop\.Net Projects\AddressBook-Management-System\AddressBook-Management-System\Utility\AddressRecord.json";
        public void WriteToFile(Dictionary<string, AddressBookBuider> addressBookDictionary)
        {
            foreach (AddressBookBuider obj in addressBookDictionary.Values)
            {
                foreach (Contacts contact in obj.addressBook.Values)
                {
                    string json = JsonConvert.SerializeObject(contact);
                    File.WriteAllText(filePath, json);
                }
            }
            Console.WriteLine("\nSuccessfully added to JSON file.");
        }
        public void ReadFromFile()
        {
            Contacts contact = JsonConvert.DeserializeObject<Contacts>(File.ReadAllText(filePath));
            Console.WriteLine(contact.ToString());
        }
    }
}
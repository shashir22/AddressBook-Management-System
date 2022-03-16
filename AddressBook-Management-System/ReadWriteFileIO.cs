using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Management_System
{
    class ReadWriteFileIO
    {
        static string file = @"C:\Users\shashiRgowda\Desktop\.Net Projects\AddressBook-Management-System\AddressBook-Management-System\Utility\AddressBook.txt";

        public void WriteToFile(Dictionary<string, AddressBookBuider> addressBookDictionary)
        {
            StreamWriter writer = new StreamWriter(file, true);
            foreach (AddressBookBuider item in addressBookDictionary.Values)
            {
                foreach (Contacts contact in item.addressBook.Values)
                {
                    writer.WriteLine(contact.ToString());
                }
            }
            Console.WriteLine("\nSuccessfully added to Text file.");
            writer.Close();
        }
        public void ReadFromFile()
        {
            Console.WriteLine(File.ReadAllText(file));
        }
    }
}
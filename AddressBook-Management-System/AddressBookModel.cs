using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook_DataBase
{
    public class AddressBookModel
    {
        internal DateTime date_added;

        public int person_id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string book_type { get; set; }
        public int book_id { get; set; }
        public string book_name { get; set; }
        public string city { get; set; }
        public int zip { get; set; }
        public string state { get; set; }
    }
}
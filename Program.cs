﻿using System;

namespace AddressBook_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book System");
            Contacts contact = new Contacts();
            contact.addContact();
        }
    }
}

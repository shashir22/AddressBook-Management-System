﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Management_System
{
    public class Contacts
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public int Zip { get; set; }
        public long PhoneNumber { get; set; }
        public Contacts(string firstName, string lastName, string address, string city, string state, string email, int zip, long phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Email = email;
            Zip = zip;
            PhoneNumber = phoneNumber;
        }

        public override bool Equals(object obj)
        {
            Contacts contact = (Contacts)obj;
            if (contact == null)
                return false;
            else
                return FirstName.Equals(contact.FirstName) && LastName.Equals(contact.LastName);
        }

        public override string ToString()
        {
            return "First Name :" + FirstName + "\nLast Name : " + LastName + "\nCity : " + City + "\nState : " + State + "\nEmail : " + Email + "\nZip : " + Zip + "\nPhone Number : " + PhoneNumber + "\n";
        }
    }
}
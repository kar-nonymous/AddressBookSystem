using System;
using System.Collections.Generic;

namespace UC4_AddressBook
{
    class Contacts
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city;
        public string state;
        public string email;
        public string zip;
        public string phnNo;
        List<Contacts> addressBookList = new List<Contacts>();

        public Contacts()
        { }


        public Contacts(string firstName, string lastName, string address, string city, string state, string email, string zip, string phnNo)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.email = email;
            this.zip = zip;
            this.phnNo = phnNo;

        }


        public void editDetails(string name)
        {
            Contacts contacts = new Contacts();
            contacts = addressBookList[1];
            if (contacts.firstName == name)
            {
                Console.WriteLine("Enter the details to edit");

                contacts.firstName = Console.ReadLine();
                contacts.lastName = Console.ReadLine();
                contacts.address = Console.ReadLine();
                contacts.city = Console.ReadLine();
                contacts.state = Console.ReadLine();
                contacts.email = Console.ReadLine();
                contacts.zip = Console.ReadLine();
                contacts.phnNo = Console.ReadLine();
            }
            else
                Console.WriteLine("No details found with the given name");


        }

        public void enterDetails()
        {
            Console.WriteLine("Enter Contact Details");
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last Name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter Address ");
            string address = Console.ReadLine();

            Console.WriteLine("Enter city Name");
            string city = Console.ReadLine();

            Console.WriteLine("Enter state Name");
            string state = Console.ReadLine();

            Console.WriteLine("Enter email id");
            string email = Console.ReadLine();

            Console.WriteLine("Enter Zip code");
            string zip = Console.ReadLine();

            Console.WriteLine("Enter Phone Number");
            string phnNo = Console.ReadLine();

            Contacts contacts = new Contacts(firstName, lastName, address, city, state, email, zip, phnNo);


            new Contacts().addressBookList.Add(contacts);

        }
        public void deleteContact(string name)
        {
            Contacts contacts = new Contacts();
            if (contacts.firstName == name)
                addressBookList.Remove(contacts);

        }

        static void Main(string[] args)
        {
            Contacts c = new Contacts();
            Console.WriteLine("Welcome to Address Book Management");
            Console.WriteLine("Enter the choice");
            Console.WriteLine("1: Enter contact details   2: Edit contact details  3: Delete contact ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    c.enterDetails();
                    break;

                case 2:
                    Console.WriteLine("Enter the frstname to edit contact details ");
                    string name = Console.ReadLine();
                    c.editDetails(name);
                    break;

                case 3:
                    Console.WriteLine("Enter the name to delete contact details");
                    string Name = Console.ReadLine();
                    break;

                default:
                    break;
            }
        }
    }
}
// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace ContactsApp
{
    class Contacts
    {
        private string name;
        private string surname;
        private long number;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public long Number { get => number; set => number = value; }

        public Contacts(string name, string surname, long number)
        {
            this.Name = name;
            this.Surname = surname;
            this.Number = number;
        }

        public Contacts()
        {
        }

        public static void PrintContacts(Dictionary<string,Contacts> contacts) //a dan z ye ve tersi seçenekli
        {
            Console.WriteLine("\n********************* CONTACTS *************************");
            Console.WriteLine("Please select one of the options below to decide the listing order: \n 1. A to Z \n 2. Z to A");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
               for (char i = 'a'; i <= 'z'; i++)
               {
                foreach (var item in contacts.Values)
                {
                    if (item.Name.ToLower()[0] == i || item.Name.ToUpper()[0] == i)
                    {
                        Console.WriteLine("\nContact Information for names starting with: " + i);
                        Console.WriteLine("Name    : " + item.Name);
                        Console.WriteLine("Surname : " + item.Surname);
                        Console.WriteLine("Number  : " + item.Number);
                        Console.WriteLine("--------------------------------------------");
                    }
                }
               } 
            }
            else
            {
                for (char i = 'z'; i >= 'a'; i--)
               {
                foreach (var item in contacts.Values)
                {
                    if (item.Name.ToUpper()[0] == i || item.Name.ToLower()[0] == i)
                    {
                        Console.WriteLine("\nContact Information for names starting with: " + i);
                        Console.WriteLine("Name    : " + item.Name);
                        Console.WriteLine("Surname : " + item.Surname);
                        Console.WriteLine("Number  : " + item.Number);
                        Console.WriteLine("--------------------------------------------");
                    }
                }
               }
            }

        }

        public static void SearchContact(Dictionary<string,Contacts> contacts){
            Console.WriteLine("Please select the search type below.\n********************************************** \nBy name or surname: (1)"+ 
            " \nBy phone number: (2)");

            string choice = Console.ReadLine();

            
            if (choice == "1")
            {
                Console.Write("Please enter the name you want to search for : ");
                string input = Console.ReadLine();

                if (contacts.ContainsKey(input))
                {
                    Contacts contact = contacts[input];
                    
                    Console.WriteLine("\nContact Information for " + input);
                    Console.WriteLine("Name    : " + contact.Name);
                    Console.WriteLine("Surname : " + contact.Surname);
                    Console.WriteLine("Number  : " + contact.Number);
                }

                else
                    Console.WriteLine("Contact not found.");
            }
            else if (choice == "2")
            {
                Console.Write("Please enter the number you want to search for : ");
                long no = long.Parse(Console.ReadLine());

                bool found = false;

                foreach (var contact in contacts.Values)
                {
                    if (contact.Number == no)
                    {
                        found = true;
                        Console.WriteLine("\nContact Information for " + no);
                        Console.WriteLine("Name    : " + contact.Name);
                        Console.WriteLine("Surname : " + contact.Surname);
                        Console.WriteLine("Number  : " + contact.Number);
                    }
                }

                if (!found)
                    Console.WriteLine("Contact not found.");
            }
            else
                Console.WriteLine("Invalid value.");
        }

        public static void SaveContact(Dictionary<string,Contacts> contacts){

            Console.Write("\nPlease enter a name         : ");
            string nameInput = Console.ReadLine();

            Console.Write("\nPlease enter a surname      : ");
            string surnameInput = Console.ReadLine();

            Console.Write("\nPlease enter phone number   : ");
            long numberInput = long.Parse(Console.ReadLine());

             string fullName = $"{nameInput} {surnameInput}";

            if (contacts.ContainsKey(fullName))
            {
                Console.WriteLine("That contact already exists.");
            }
            else
            {
                contacts.Add(fullName, new Contacts { Name = nameInput, Surname = surnameInput, Number = numberInput });
                Console.WriteLine("Contact saved successfully!");
                Console.WriteLine("\nAll Contacts After Adding:");
                PrintContacts(contacts);
            }
            
        }

        public static void UpdateContact(Dictionary<string,Contacts> contacts){

            Console.Write("Please enter the contact's name and surname to update : ");
            string input = Console.ReadLine();

            if (contacts.ContainsKey(input))
            {
                Console.WriteLine("Please select what do you want to update: \n 1. Update Name \n 2. Update Phone Number");
                string updateChoice = Console.ReadLine();

                switch (updateChoice)
                {
                    case "1":
                        Console.Write("Please enter the new name: ");
                        string newName = Console.ReadLine();
                        contacts[input].Name = newName;

                        Console.Write("Please enter the new surname: ");
                        string newSurname = Console.ReadLine();
                        contacts[input].Surname = newSurname;

                        Console.WriteLine("Contact name updated successfully!");
                        break;
                    case "2":
                        Console.Write("Please enter the new phone number:");
                        long newNumber = long.Parse(Console.ReadLine());
                        contacts[input].Number = newNumber;
                        Console.WriteLine("Contact phone number updated successfully!");
                        break;
                    
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                PrintContacts(contacts);
            }
            else
            {
                Console.WriteLine("Contact not found. Please choose one of these options below. \n* To end the update : (1) \n* To try again        : (2)");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    return;
                }
                else if (choice == "2")
                {
                    UpdateContact(contacts); 
                }
            }

        }

        public static void DeleteContact(Dictionary<string,Contacts> contacts){

            Console.Write("Please enter the contact's name and surname to delete : ");
            string deleteInput = Console.ReadLine();

            if (contacts.ContainsKey(deleteInput))
            {
                Console.Write($"{deleteInput} is about to be deleted, do you confirm? (y/n):"); 
                string answer = Console.ReadLine();

                if(answer == "y"){
                    contacts.Remove(deleteInput); // Not: Rehber uygun kriterlere uygun birden fazla kişi bulunursa ilk bulunan silinmeli.
                    Console.WriteLine("Contact deleted successfully!");
                    PrintContacts(contacts);
                }
                else
                {
                    return;
                }
                
            }
            else
            {
                Console.WriteLine("Contact not found. Please choose one of these options below. \n* To end the deletion : (1) \n* To try again        : (2)");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    return;
                }
                else if (choice == "2") 
                {
                    DeleteContact(contacts);

                }
                else
                    Console.WriteLine("Invalid input.");
            }

        }

    class Program
    {
        public static void Main(string[] args)
        {
            
            Dictionary<string,Contacts> contacts = new Dictionary<string, Contacts>();

            contacts.Add("Merve Güngör", new Contacts { Name = "Merve", Surname = "Güngör", Number = 1234567899 });
            contacts.Add("Mert Güney", new Contacts { Name = "Mert", Surname = "Güney", Number = 4456231234 });
            contacts.Add("Elvan Başak", new Contacts { Name = "Elvan", Surname = "Başak", Number = 5210356489 });
            contacts.Add("Armağan Yaşar", new Contacts { Name = "Armağan", Surname = "Yaşar", Number = 5896457123 });
            contacts.Add("Nergis Sever", new Contacts { Name = "Nergis", Surname = "Sever", Number = 4789651457 });
            contacts.Add("Nergis Sever İş", new Contacts { Name = "Nergis", Surname = "Sever", Number = 5352146879 });

            Console.WriteLine("Please select the action you want to perform \n*******************************************" 
            +"\n(1) Save New Contact \n(2) Delete Contact \n(3) Update Contact \n(4) List the Contacts" 
            +"\n(5) Searching for Contact");

            string input = Console.ReadLine();

            switch(input){ 
                case "1":
                    Contacts.SaveContact(contacts);    
                    break;
                case "2":
                    Contacts.DeleteContact(contacts);  
                    break;
                case "3":
                    Contacts.UpdateContact(contacts);  
                    break;
                case "4":
                    Contacts.PrintContacts(contacts);    
                    break;
                case "5":
                    Contacts.SearchContact(contacts);  
                    break;
                default:
                    Console.WriteLine("Input is not valid.");
                    break;
            } 
        }
    }   
  }
}
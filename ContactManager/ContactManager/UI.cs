using System;
using System.Collections.Generic;
using ContactManager.Core;

namespace ContactManager
{
    public class UI
    {
        private List<Contact> contacts = new List<Contact>();

        public void Run()
        {
            Console.WriteLine("Welcome to the Contact Manager!");

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Individual Contact");
                Console.WriteLine("2. Add Company Contact");
                Console.WriteLine("3. Display All Contacts");
                Console.WriteLine("4. Exit");
                Console.Write("Please select an option: ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddIndividualContact();
                            break;
                        case 2:
                            AddCompanyContact();
                            break;
                        case 3:
                            DisplayAllContacts();
                            break;
                        case 4:
                            Console.WriteLine("Exiting Contact Manager. Goodbye!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }

        private void AddIndividualContact()
        {
            Console.WriteLine("\nAdding Individual Contact:");
            Individual individual = new Individual();

            Console.Write("First Name: ");
            individual.FirstName = Console.ReadLine();

            Console.Write("Last Name: ");
            individual.LastName = Console.ReadLine();

            Console.Write("Phone Number: ");
            individual.PhoneNumber = Console.ReadLine();

            Console.Write("Email: ");
            individual.Email = Console.ReadLine();

            contacts.Add(individual);
            Console.WriteLine("Individual contact added successfully!");
        }

        private void AddCompanyContact()
        {
            Console.WriteLine("\nAdding Company Contact:");
            Company company = new Company();

            Console.Write("Company Name: ");
            company.Name = Console.ReadLine();

            // You can add more properties to the Company class here.

            contacts.Add(company);
            Console.WriteLine("Company contact added successfully!");
        }

        private void DisplayAllContacts()
        {
            Console.WriteLine("\nAll Contacts:");

            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.GetType().Name} - Name: {contact.Name}");
            }
        }
    }
}


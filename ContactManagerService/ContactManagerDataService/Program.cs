using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using ContactManagerDataService.DataStorage;
using SharedContactManager.Models;
using System;

namespace ContactManagerDataService
{
    class Program
    {
        static void Main()
        {
            // Create the data storage instance (using IDataStorage<Contact> interface)
            IDataStorage<Contact> dataStorage = new ArrayDataStorage<Contact>();

            // Create some contacts and add them to the storage
            Contact contact1 = new Contact { Id = 1, Name = "John Doe", Email = "john.doe@example.com" };
            Contact contact2 = new Contact { Id = 2, Name = "Jane Smith", Email = "jane.smith@example.com" };
            dataStorage.Create(contact1);
            dataStorage.Create(contact2);

            // Retrieve all contacts and print them
            var allContacts = dataStorage.RetrieveAll();
            Console.WriteLine("All Contacts:");
            foreach (var contact in allContacts)
            {
                Console.WriteLine($"{contact.Id}: {contact.Name} - {contact.Email}");
            }

            // Retrieve a specific contact by ID
            int contactIdToRetrieve = 2;
            var retrievedContact = dataStorage.Retrieve(contactIdToRetrieve);
            Console.WriteLine($"\nRetrieved Contact (ID: {contactIdToRetrieve}):");
            Console.WriteLine($"{retrievedContact.Id}: {retrievedContact.Name} - {retrievedContact.Email}");

            // Update a contact
            retrievedContact.Name = "Jane Johnson";
            dataStorage.Update(retrievedContact);
            Console.WriteLine("\nUpdated Contact:");
            Console.WriteLine($"{retrievedContact.Id}: {retrievedContact.Name} - {retrievedContact.Email}");

            // Retrieve all contacts again to see the changes
            allContacts = dataStorage.RetrieveAll();
            Console.WriteLine("\nAll Contacts after Update:");
            foreach (var contact in allContacts)
            {
                Console.WriteLine($"{contact.Id}: {contact.Name} - {contact.Email}");
            }

            // Delete a contact
            int contactIdToDelete = 1;
            dataStorage.Delete(contactIdToDelete);
            Console.WriteLine($"\nContact with ID {contactIdToDelete} deleted.");

            // Retrieve all contacts after deletion
            allContacts = dataStorage.RetrieveAll();
            Console.WriteLine("\nAll Contacts after Deletion:");
            foreach (var contact in allContacts)
            {
                Console.WriteLine($"{contact.Id}: {contact.Name} - {contact.Email}");
            }
        }
    }
}

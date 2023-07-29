// In the ContactManagerService project

using SharedContactManager.Models;
using SharedContactManager.Services;
using SharedContactManager.Services;
using System;

namespace ContactManagerService
{
    class Program
    {
        private readonly IContactService contactService;

        public Program(IContactService contactService)
        {
            this.contactService = contactService;
        }

        static void Main()
        {
            
            IContactService contactService = new ContactService();
            var program = new Program(contactService);

            
        }

        private void AddNewContact()
        {
           
            var newContact = new Contact { Name = "John Doe", Email = "john.doe@example.com" };
            contactService.AddContact(newContact);
        }

        // Implement other methods to perform other operations using the contactService.
    }
}

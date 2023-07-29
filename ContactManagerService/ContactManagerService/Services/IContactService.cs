using SharedContactManager.Models;
using System.Collections.Generic;

namespace ContactManagerService.Services
{
    public interface IContactService
    {
        
        void AddContact(Contact contact);
        Contact GetContactById(int id);
        List<Contact> GetAllContacts();
        void UpdateContact(Contact contact);
        void RemoveContact(int id);
       
    }
}

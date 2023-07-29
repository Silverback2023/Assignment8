using SharedContactManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SharedContactManager.Services
{
    public interface IContactService
    {
        void AddContact(Contact contact);
        Contact GetContactById(int id);
        List<Contact> GetAllContacts();
        void UpdateContact(Contact contact);
        void RemoveContact(int id);
        
    }

    public interface IDataService
    {
        void SaveContacts(List<Contact> contacts);
        List<Contact> LoadContacts();
    }
}

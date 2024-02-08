using ContactWebModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyContactManagerServices
{
    public class ContactsService : IContactsService
    {
        Task<int> IContactsService.AddOrUpdateAsync(Contact state, string userId)
        {
            throw new NotImplementedException();
        }

        Task<int> IContactsService.DeleteAsync(Contact state, string userId)
        {
            throw new NotImplementedException();
        }

        Task<int> IContactsService.DeleteAsync(int id, string userId)
        {
            throw new NotImplementedException();
        }

        Task<bool> IContactsService.ExistsAsync(int id, string userId)
        {
            throw new NotImplementedException();
        }

        Task<IList<Contact>> IContactsService.GetAllAsync(string userId)
        {
            throw new NotImplementedException();
        }

        Task<Contact> IContactsService.GetAsync(int id, string userId)
        {
            throw new NotImplementedException();
        }
    }
}

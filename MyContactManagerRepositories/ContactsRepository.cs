using ContactWebModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyContactManagerRepositories
{
    public class ContactsRepository : IContactsRepository
    {
        public async Task<int> AddOrUpdateAsync(Contact state, string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteAsync(Contact state, string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<int> DeleteAsync(int id, string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistsAsync(int id, string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Contact>> GetAllAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<Contact> GetAsync(int id, string userId)
        {
            throw new NotImplementedException();
        }
    }
}

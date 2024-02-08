using ContactWebModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyContactManagerRepositories
{
    public interface IStatesRepository
    {
        Task<IList<State>> GetAllAsync();
        Task<State?> GetAsync(int id);
        Task<int> AddOrUpdateAsync(State state);
        Task<int> DeleteAsync(State state);
        Task<int> DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
    }
}

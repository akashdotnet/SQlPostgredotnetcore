using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PostgreSQLDB.Models;

namespace PostgreSQLDB.Interface
{
    public interface IGroupViewModelService
    {
        Task<IEnumerable<Group>> GetGroup();
        Task<Group> GetGroup(int id);
        Task<Group> CreateGroup(Group group);
        Task UpdateGroup(Group group);
        Task DeleteGroup(int id);
    }
}

using PostgreSQLDB.DB;
using PostgreSQLDB.Interface;
using PostgreSQLDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgreSQLDB.Service
{
    public class GroupViewModelService : IGroupViewModelService
    {
        private readonly IAsyncRepository<Group> _itemRepository;

        public GroupViewModelService(IAsyncRepository<Group> itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public async Task<IEnumerable<Group>> GetGroup()
        {
            var items = await _itemRepository.ListAllAsync();
            return items;
        }

        public async Task<Group> GetGroup(int id)
        {
            var item = await _itemRepository.GetByIdAsync(id);
            return item;
        }

        public async Task<Group> CreateGroup(Group group)
        {
            var item = await _itemRepository.AddAsync(group);
            return item;
        }

        public async Task UpdateGroup(Group group)
        {

            await _itemRepository.UpdateAsync(group);
        }

        public async Task DeleteGroup(int id)
        {
            var item = await _itemRepository.GetByIdAsync(id);
            await _itemRepository.DeleteAsync(item);
        }
    }
}

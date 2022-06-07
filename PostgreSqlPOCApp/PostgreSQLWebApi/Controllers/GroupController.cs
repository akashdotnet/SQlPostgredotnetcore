using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PostgreSQLDB.Interface;
using PostgreSQLDB.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PostgreSQLWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly IGroupViewModelService _groupViewModelService;

        public GroupsController(IGroupViewModelService groupViewModelService)
        {
            _groupViewModelService = groupViewModelService;
        }

        // GET: api/<GroupController>
        [HttpGet]
        public async Task<IEnumerable<Group>> Get()
        {
            return await _groupViewModelService.GetGroup();
        }

        // GET api/<GroupController>/5
        [HttpGet("{id}")]
        public async Task<Group> Get(int id)
        {
            return await _groupViewModelService.GetGroup(id);
        }

        // POST api/<GroupController>
        [HttpPost]
        public async Task<Group> Post(Group group)
        {
            return await _groupViewModelService.CreateGroup(group);
        }

        // PUT api/<GroupController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, Group group)
        {
            await _groupViewModelService.UpdateGroup(group);
        }

        // DELETE api/<GroupController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _groupViewModelService.DeleteGroup(id);
        }
    }
}

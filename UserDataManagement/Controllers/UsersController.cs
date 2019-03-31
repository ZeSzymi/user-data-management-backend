using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using userDataManagement.Dtos;
using userDataManagement.IRepositories;
using userDataManagement.Models;
using userDataManagement.ModelsDb;

namespace userDataManagement.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly IUsersRepository _usersReposiotry;
        private readonly IMapper _mapper;

        public UsersController(IUsersRepository usersReposiotry, IMapper mapper)
        {
            _usersReposiotry = usersReposiotry;
            _mapper = mapper;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetUsers() {
            try {
                return Ok(_mapper.Map<List<UserDto>>(await _usersReposiotry.GetUsers()));
            }
            catch {
                return BadRequest("Błąd przy zwracaniu użytkowników");
            }
        }

        [HttpPost()]
        [Route("add")]
        public async Task<IActionResult> AddUser([FromBody] UserDto user) {

            try {
                return Ok(await _usersReposiotry.AddUser(_mapper.Map<UserDb>(user)));
            }
            catch (Exception ex) {               
               return BadRequest("Bład przy dodawaniu nowego użytkownika" + ex.Message);
            } 
        }      
        [HttpPost()]
        [Route("remove")]
        public async Task<IActionResult> RemoveUser([FromBody] UserDto user) {

            try {
                return Ok(await _usersReposiotry.RemoveUser(_mapper.Map<UserDb>(user)));
            }
            catch (Exception ex) {               
               return BadRequest("Bład przy dodawaniu nowego użytkownika" + ex.Message);
            } 
        }      
    }
}
    
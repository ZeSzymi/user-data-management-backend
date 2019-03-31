
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using userDataManagement.Models;
using userDataManagement.ModelsDb;

namespace userDataManagement.IRepositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly ManagementContext _context;

        public UsersRepository(ManagementContext context)
        {
            _context = context;
        }

        public async Task<UserDb> AddUser(UserDb user)
        {
            user.Id = 0;
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }

        public async Task<List<UserDb>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<UserDb> RemoveUser(UserDb user)
        {
            var userToRemove = await _context.Users.FirstAsync(u => u.Id == user.Id);
            _context.Users.Attach(userToRemove);
            _context.Remove(userToRemove);
            await _context.SaveChangesAsync();
            return user;
        }
    }
}
    
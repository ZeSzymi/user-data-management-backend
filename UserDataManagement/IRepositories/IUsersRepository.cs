
using System.Collections.Generic;
using System.Threading.Tasks;
using userDataManagement.ModelsDb;

namespace userDataManagement.IRepositories
{
    public interface IUsersRepository
    {
        Task<List<UserDb>> GetUsers();
        Task<UserDb> AddUser(UserDb User);
        Task<UserDb> RemoveUser(UserDb User);
    } 
}
    
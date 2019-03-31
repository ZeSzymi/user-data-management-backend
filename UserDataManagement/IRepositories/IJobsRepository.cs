
using System.Collections.Generic;
using System.Threading.Tasks;
using userDataManagement.ModelsDb;

namespace userDataManagement.IRepositories
{
    public interface IJobsRepository
    {
        Task<List<JobDb>> GetJobs();
        Task<JobDb> AddJob(JobDb Job);
        Task<JobDb> RemoveJob(JobDb Job);
    } 
}
    

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using userDataManagement.Models;
using userDataManagement.ModelsDb;

namespace userDataManagement.IRepositories
{
    public class JobsRepository : IJobsRepository
    {
        private readonly ManagementContext _context;

        public JobsRepository(ManagementContext context)
        {
            _context = context;
        }

        public async Task<JobDb> AddJob(JobDb job)
        {
            job.Id = 0;
            var newJob = new JobDb {
                Id = 0,
                Name = job.Name,
                UserId = job.UserId,
                ClientId = job.ClientId,
                HoursReported = job.HoursReported
            };
            await _context.Jobs.AddAsync(newJob);
            await _context.SaveChangesAsync();
            return job;
        }

        public async Task<List<JobDb>> GetJobs()
        {
            return await _context.Jobs.Include(j => j.User).ToListAsync();
        }

        public async Task<JobDb> RemoveJob(JobDb job)
        {
            var jobToRemove = await _context.Jobs.FirstAsync(u => u.Id == job.Id);
            _context.Jobs.Attach(jobToRemove);
            _context.Remove(jobToRemove);
            await _context.SaveChangesAsync();
            return job;
        }
    }
}
    
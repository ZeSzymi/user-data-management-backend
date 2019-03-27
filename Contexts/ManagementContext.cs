using Microsoft.EntityFrameworkCore;
using userDataManagement.Models;

public class ManagementContext : DbContext
{
     public ManagementContext(DbContextOptions<ManagementContext> options) : base(options) { }
    public DbSet<User> Users { get; set; }
    public DbSet<Job> Jobs { get; set; }
    public DbSet<UserJob> UsersJobs { get; set; }
    public DbSet<Client> Clients { get; set; }
}
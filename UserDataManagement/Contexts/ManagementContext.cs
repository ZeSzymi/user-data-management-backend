using Microsoft.EntityFrameworkCore;
using userDataManagement.Models;
using userDataManagement.ModelsDb;

public class ManagementContext : DbContext
{
    public ManagementContext(DbContextOptions<ManagementContext> options) : base(options) { }
    public DbSet<UserDb> Users { get; set; }
    public DbSet<JobDb> Jobs { get; set; }
    public DbSet<ClientDb> Clients { get; set; }
}
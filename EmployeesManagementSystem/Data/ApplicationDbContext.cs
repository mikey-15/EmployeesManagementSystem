using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmployeesManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Models.Employee> Employees { get; set; }
        public DbSet<Models.Department> Departments { get; set; }
        public DbSet<Models.Designation> Designations { get; set; }
        public DbSet<Models.SystemCode> SystemCodes { get; set; }
        public DbSet<Models.SystemCodeDetail> SystemCodeDetails { get; set; }
        public DbSet<Models.LeaveType> LeaveTypes { get; set; }
        public DbSet<Models.Bank> Banks { get; set; }
    }
}
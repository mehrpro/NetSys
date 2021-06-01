using Microsoft.EntityFrameworkCore;
using Net.Entities.Entity;

namespace Net.Data
{
    public class ApplicationContext  : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            .UseSqlServer(
                "Data Source=(local);Initial Catalog=NetDB;user id=sa;password=sa123sa;MultipleActiveResultSets=True;");

        }

        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public virtual DbSet<Applicant> Applicants { get; set; }
        public virtual DbSet<Coding> Codings { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<ConsumablePart> ConsumableParts { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Machinery> Machineries { get; set; }
        public virtual DbSet<RequestRepair> RequestRepairs { get; set; }
        public virtual DbSet<SubGroup> SubGroups { get; set; }
        public virtual DbSet<TypeofRepair> TypeofRepairs { get; set; }
        public virtual DbSet<WorkOrder> WorkOrders { get; set; }


    }
}

using Microsoft.EntityFrameworkCore;
namespace CloudForge.Api.Models
{
    public class InstancesContext : DbContext
    {
        public InstancesContext(DbContextOptions<InstancesContext> options) : base(options)
        {
        }
        public DbSet<Instances> Instances { get; set; } = null!;
    }
}

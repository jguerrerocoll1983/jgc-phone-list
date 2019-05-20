namespace JGCPhoneList.Persistence
{
    using System.Threading.Tasks;

    using JGCPhoneList.Domain.Entities;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.ChangeTracking;

    public class JgcPhoneListDbContext : DbContext, IJgcPhoneListDbContext
    {
        public JgcPhoneListDbContext(DbContextOptions<JgcPhoneListDbContext> options)
            : base(options)
        {
        }

        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<OperativeSystem> OperativeSystems { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<PhoneImages> PhoneImages { get; set; }
        public DbSet<PhoneColors> PhoneColors { get; set; }

        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }

        public EntityEntry<Phone> Entry<TEntity>(Phone entity)
        {
            return base.Entry<Phone>(entity);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(JgcPhoneListDbContext).Assembly);
        }
    }
}
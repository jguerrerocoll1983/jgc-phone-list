namespace JGCPhoneList.Persistence
{
    using System.Threading;
    using System.Threading.Tasks;

    using JGCPhoneList.Domain.Entities;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.ChangeTracking;

    public interface IJgcPhoneListDbContext
    {
        DbSet<Manufacturer> Manufacturers { get; set; }
        DbSet<OperativeSystem> OperativeSystems { get; set; }
        DbSet<Phone> Phones { get; set; }
        DbSet<Color> Colors { get; set; }
        DbSet<Image> Images { get; set; }
        DbSet<PhoneImages> PhoneImages { get; set; }
        DbSet<PhoneColors> PhoneColors { get; set; }


        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        EntityEntry<Phone> Entry<TEntity>(Phone entity);
    }
}
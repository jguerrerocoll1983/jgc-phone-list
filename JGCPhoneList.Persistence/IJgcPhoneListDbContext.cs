namespace JGCPhoneList.Persistence
{
    using JGCPhoneList.Domain.Entities;

    using Microsoft.EntityFrameworkCore;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IJgcPhoneListDbContext
    {
        DbSet<Manufacturer> Manufacturers { get; set; }
        DbSet<OperativeSystem> OperativeSystems { get; set; }
        DbSet<Phone> Phones { get; set; }
        DbSet<Color> Colors { get; set; }
        DbSet<Image> Images { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
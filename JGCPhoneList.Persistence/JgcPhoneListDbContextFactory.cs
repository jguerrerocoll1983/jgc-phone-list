using JGCPhoneList.Persistence.Infrastructure;

namespace JGCPhoneList.Persistence
{
    using Microsoft.EntityFrameworkCore;

    public class JgcPhoneListDbContextFactory : DesignTimeDbContextFactoryBase<JgcPhoneListDbContext>
    {
        protected override JgcPhoneListDbContext CreateNewInstance(DbContextOptions<JgcPhoneListDbContext> options)
        {
            return new JgcPhoneListDbContext(options);
        }
    }
}
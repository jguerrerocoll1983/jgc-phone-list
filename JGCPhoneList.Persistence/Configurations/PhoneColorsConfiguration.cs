using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JGCPhoneList.Persistence.Configurations
{
    using JGCPhoneList.Domain.Entities;
    using Microsoft.EntityFrameworkCore;

    public class PhoneColorsConfiguration : IEntityTypeConfiguration<PhoneColors>
    {
        public void Configure(EntityTypeBuilder<PhoneColors> builder)
        {
            builder.HasKey(e => new { e.PhoneId, e.ColorId });
        }
    }
}
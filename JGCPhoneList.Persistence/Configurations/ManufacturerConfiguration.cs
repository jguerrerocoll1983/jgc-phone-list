namespace JGCPhoneList.Persistence.Configurations
{
    using JGCPhoneList.Domain.Entities;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ManufacturerConfiguration : IEntityTypeConfiguration<Manufacturer>
    {
        public void Configure(EntityTypeBuilder<Manufacturer> builder)
        {
            builder.Property(e => e.ManufacturerId).HasColumnName("ManufacturerId");

            builder.Property(e => e.Description)
                .IsRequired()
                .HasColumnType("ntext");

            builder.Property(e => e.Country).HasMaxLength(100);
        }
    }
}
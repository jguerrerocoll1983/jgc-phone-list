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

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.Description)
                .IsRequired()
                .HasColumnType("ntext");

            builder.Property(e => e.Country).HasMaxLength(100);

            builder.HasMany(os => os.OperativeSystems)
                .WithOne(os => os.Manufacturer)
                .HasForeignKey(os => os.OperativeSystemId)
                .HasConstraintName("FK_Manufacturer_OperativeSystemId");
        }
    }
}
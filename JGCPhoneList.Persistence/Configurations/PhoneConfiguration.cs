namespace JGCPhoneList.Persistence.Configurations
{
    using JGCPhoneList.Domain.Entities;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class PhoneConfiguration : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
            builder.Property(e => e.PhoneId).HasColumnName("PhoneId");

            builder.Property(e => e.Model)
                .IsRequired()
                .HasMaxLength(120);

            builder.Property(e => e.Description)
                .IsRequired()
                .HasColumnType("ntext");

            builder.Property(e => e.Price)
                .IsRequired();

            builder.Property(e => e.Resolution)
                .HasMaxLength(50);

            builder.Property(e => e.Manufacturer).IsRequired();

            builder.Property(e => e.OperativeSystem).IsRequired();
        }
    }
}
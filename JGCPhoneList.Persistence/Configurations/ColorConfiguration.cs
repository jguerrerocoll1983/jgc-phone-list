namespace JGCPhoneList.Persistence.Configurations
{
    using JGCPhoneList.Domain.Entities;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ColorConfiguration : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.Property(e => e.ColorId).HasColumnName("ColorId");

            builder.Property(e => e.Name).IsRequired();

            builder.Property(e => e.RValue).IsRequired();

            builder.Property(e => e.GValue).IsRequired();

            builder.Property(e => e.BValue).IsRequired();
        }
    }
}
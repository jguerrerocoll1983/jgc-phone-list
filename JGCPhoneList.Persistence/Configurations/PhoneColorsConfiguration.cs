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

            builder.HasOne(pc => pc.Phone)
                .WithMany(p => p.PhoneColors)
                .HasForeignKey(pc => pc.PhoneId)
                .HasConstraintName("FK_PhoneColors_PhoneId");


            builder.HasOne(pc => pc.Color)
                .WithMany(p => p.PhoneColors)
                .HasForeignKey(pc => pc.ColorId)
                .HasConstraintName("FK_PhoneColors_ColorId");
        }
    }
}
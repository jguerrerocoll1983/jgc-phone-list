namespace JGCPhoneList.Persistence.Configurations
{
    using JGCPhoneList.Domain.Entities;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class OperativeSystemConfiguration : IEntityTypeConfiguration<OperativeSystem>
    {
        public void Configure(EntityTypeBuilder<OperativeSystem> builder)
        {
            builder.Property(e => e.OperativeSystemId).HasColumnName("OperativeSystemId");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Description)
                .IsRequired()
                .HasColumnType("ntext");

            builder.Property(e => e.Url).HasMaxLength(100);

            builder.HasOne(os => os.Manufacturer)
                .WithMany(os => os.OperativeSystems)
                .HasForeignKey(os => os.OperativeSystemId)
                .HasConstraintName("FK_Manufacturer_OperativeSystemId");
        }
    }
}
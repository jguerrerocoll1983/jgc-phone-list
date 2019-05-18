namespace JGCPhoneList.Persistence.Configurations
{
    using JGCPhoneList.Domain.Entities;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class PhoneImagesConfiguration : IEntityTypeConfiguration<PhoneImages>
    {
        public void Configure(EntityTypeBuilder<PhoneImages> builder)
        {
            builder.HasKey(e => new { e.PhoneId, e.ImageId });
        }
    }
}
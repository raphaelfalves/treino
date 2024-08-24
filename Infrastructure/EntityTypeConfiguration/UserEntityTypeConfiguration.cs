using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityTypeConfiguration
{
    class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Weight).HasPrecision(18,2);
            builder.Property(x => x.TargetWeight).HasPrecision(18,2);
            builder.Property(x => x.Height).HasPrecision(18,2);
        }
    }
}

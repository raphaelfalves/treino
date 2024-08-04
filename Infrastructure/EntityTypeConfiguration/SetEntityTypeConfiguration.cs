using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityTypeConfiguration;

public class SetEntityTypeConfiguration : IEntityTypeConfiguration<Set>
{
    public void Configure(EntityTypeBuilder<Set> builder)
    {
        builder.ToTable("Set");
        builder.HasKey(em => em.Id);
        builder.Property(e => e.ExerciseTrainingId);
        builder.Property(e => e.Repetition);
        builder.Property(e => e.Weight);
    }
}

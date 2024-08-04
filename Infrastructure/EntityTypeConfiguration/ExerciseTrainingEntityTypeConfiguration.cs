using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityTypeConfiguration;

public class ExerciseTrainingEntityTypeConfiguration : IEntityTypeConfiguration<ExerciseTraining>
{
    public void Configure(EntityTypeBuilder<ExerciseTraining> builder)
    {
        builder.ToTable("ExerciseTraining");
        builder.HasKey(em => em.Id);
        builder.Property(em => em.ExerciseId);
        builder.Property(em => em.TrainingId);
        builder.Property(e => e.RestBetweenSets);
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskFlow.Domain.Entities;

namespace TaskFlow.Infrastructure.Data.Configurations;

public class ProjectTaskConfiguration : IEntityTypeConfiguration<ProjectTask>
{
       public void Configure(EntityTypeBuilder<ProjectTask> builder)
       {
              builder.ToTable("Tasks");

              builder.HasKey(t => t.Id);

              builder.Property(t => t.Title)
                     .IsRequired()
                     .HasMaxLength(200);

              builder.Property(t => t.Description)
                     .HasMaxLength(1000);

              builder.Property(t => t.Status)
                     .HasConversion<string>()
                     .IsRequired();

              builder.Property(t => t.Priority)
                     .HasConversion<string>()
                     .IsRequired();

              builder.Property(t => t.ProjectId)
                     .IsRequired();
       }
}
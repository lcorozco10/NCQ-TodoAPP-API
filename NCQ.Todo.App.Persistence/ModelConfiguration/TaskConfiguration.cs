using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace NCQ.Todo.App.Persistence.ModelConfiguration
{
    public class TaskConfiguration : IEntityTypeConfiguration<Domain.Entities.Task>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Task> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Description).HasMaxLength(400).IsRequired();
            builder.Property(c => c.StateCode).IsRequired();
            builder.Property(c => c.PripriorityCode).IsRequired();
            builder.Property(c => c.StartDate).IsRequired();
            builder.Property(c => c.EndDate).IsRequired();
            builder.Property(c => c.DateCreated).HasDefaultValueSql("GETDATE()");
            builder.Property(c => c.DateUpdated).HasDefaultValueSql("GETDATE()");
        }
    }
}

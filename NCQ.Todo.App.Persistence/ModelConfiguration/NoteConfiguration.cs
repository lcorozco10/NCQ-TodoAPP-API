using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NCQ.Todo.App.Domain.Entities;

namespace NCQ.Todo.App.Persistence.ModelConfiguration
{
    public class NoteConfiguration : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Content).HasMaxLength(400).IsRequired();
            builder.Property(c => c.TaskId).IsRequired();
            builder.Property(c => c.DateCreated).HasDefaultValueSql("GETDATE()");
            builder.Property(c => c.DateUpdated).HasDefaultValueSql("GETDATE()");
        }
    }
}

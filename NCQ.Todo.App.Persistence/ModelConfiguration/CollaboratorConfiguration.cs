using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NCQ.Todo.App.Domain.Entities;

namespace NCQ.Todo.App.Persistence.ModelConfiguration
{
    public class CollaboratorConfiguration : IEntityTypeConfiguration<Collaborator>
    {
        public void Configure(EntityTypeBuilder<Collaborator> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).HasMaxLength(200).IsRequired();
            builder.Property(c => c.DateCreated).HasDefaultValueSql("GETDATE()");
            builder.Property(c => c.DateUpdated).HasDefaultValueSql("GETDATE()");
        }
    }
}

using Microsoft.EntityFrameworkCore;
using NCQ.Todo.App.Domain.Entities;

namespace NCQ.Todo.App.Persistence.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }

}

using Microsoft.EntityFrameworkCore;
using ApiOpenBootcamp.Models.DataModels;

namespace ApiOpenBootcamp.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Users>? Users { get; set; }
    }
}

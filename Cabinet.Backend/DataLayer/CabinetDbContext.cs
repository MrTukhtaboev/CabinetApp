using Cabinet.Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Cabinet.Backend.DataLayer
{
    public class CabinetDbContext : DbContext
    {
        public CabinetDbContext(DbContextOptions<CabinetDbContext> options)
        :base(options)
        {
        }
        
        public DbSet<Person> Persons { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}
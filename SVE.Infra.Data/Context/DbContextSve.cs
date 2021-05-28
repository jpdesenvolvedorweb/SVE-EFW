using Microsoft.EntityFrameworkCore;
using SVE.Domain.Models;

namespace SVE.Infra.Data.Context
{
    public class DbContextSve : DbContext
    {
        public DbContextSve()
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}

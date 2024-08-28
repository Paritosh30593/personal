using Microsoft.EntityFrameworkCore;
using personal.Models;

namespace personal.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Category> Categories { get; set; }
}

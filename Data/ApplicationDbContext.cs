using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SteelHorseTrucks.Models;

namespace SteelHorseTrucks.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SteelHorseTrucks.Models.Trucks> Trucks { get; set; } = default!;
    }
}

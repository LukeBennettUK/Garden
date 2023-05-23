using Garden.Models;
using Microsoft.EntityFrameworkCore;

namespace Garden.Data;

public class GardenDbContext : DbContext
{
    public GardenDbContext(DbContextOptions<GardenDbContext> options) : base(options) {}
    
    public DbSet<User> Users { get; set; }
    public DbSet<Models.Garden> Gardens { get; set; }
    public DbSet <GardenPlant> GardenPlants { get; set; }
    public DbSet <Plant> Plants { get; set; }
}
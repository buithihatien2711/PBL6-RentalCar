using Microsoft.EntityFrameworkCore;
using RentalCar.Model.Models;

namespace RentalCar.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
        public DbSet<CarBrand> CarBrands { get; set; }

        public DbSet<CarModel> CarModels { get; set; }

        public DbSet<District> Districts { get; set; }

        public DbSet<Ward> Wards { get; set; }
        
        public DbSet<Location> Locations { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Status> Statuses { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<RoleUser> RoleUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<RoleUser>()
                .HasKey(ru => new { ru.UserId, ru.RoleId });
            base.OnModelCreating(modelBuilder);
        }
    }
}
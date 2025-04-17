using Microsoft.EntityFrameworkCore;
using VeterinaryApp.WebApi.Model;

namespace VeterinaryApp.WebApi
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Species> Species { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Breed> Breeds { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}

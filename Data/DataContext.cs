using Microsoft.EntityFrameworkCore;
using PuneCarRideApi.model;

namespace PuneCarRideApi.Data
{
     public class DataContext : DbContext {
        public DataContext (DbContextOptions<DataContext> options) : base (options) { }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<Package> Package {get;set;}
        public DbSet<Spots> Spots {get;set;}
        public DbSet<ListedDestinations> ListeDestination {get;set;}
        public DbSet<Drivers> Drivers {get;set;}

    }
}
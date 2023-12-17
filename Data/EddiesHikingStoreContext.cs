using Microsoft.EntityFrameworkCore;
using EddiesHikingStore.Models; // Adjust the namespace to your Models namespace

namespace EddiesHikingStore.Data
{
    public class EddiesHikingStoreContext : DbContext
    {
        public EddiesHikingStoreContext(DbContextOptions<EddiesHikingStoreContext> options)
            : base(options)
        {
        }

        public DbSet<ProductModel> ProductDb { get; set; }
        public DbSet<ContactModel> ContactDb { get; set; }

        // Additional configuration, if necessary, can be placed here
    }
}

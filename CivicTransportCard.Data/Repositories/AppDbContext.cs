using CivicTransportCard.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CivicTransportCard.Data.Repositories
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public virtual DbSet<LocationEntity> Location { get; set; }
        public virtual DbSet<TransactionEntity> Transaction { get; set; }
        public virtual DbSet<TransactionLocationEntity> TransactionLocation { get; set; }
        public virtual DbSet<TransportCardEntity> TransportCard{ get; set; }
    }
}

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Models;

namespace Data
{
    public class LearnContext : DbContext
    {
        public LearnContext()
            : base("name=LearnConnection")
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
            Database.CreateIfNotExists();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Site> Sites { get; set; }
        public DbSet<Week> Weeks { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Round> Rounds { get; set; }
        public DbSet<Media> Medias { get; set; }
    }
}

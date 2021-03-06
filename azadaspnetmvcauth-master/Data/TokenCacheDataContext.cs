using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SampleMvcAzAuth.Models;

namespace SampleMvcAzAuth.Data {
  public class TokenCacheDataContext : DbContext{
    public TokenCacheDataContext()
      : base("TokenCacheDataContext") { }

    public DbSet<PerUserWebCache> PerUserCacheList { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder) {
      modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    }
  }
}
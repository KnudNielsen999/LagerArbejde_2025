namespace Winston_ERP_SystemVersion1.DB_Entity
{
    using Microsoft.EntityFrameworkCore;
    using Winston_ERP_SystemVersion1.Lager_Repos;

    public class LagerDatabase : DbContext
    {
        public LagerDatabase(DbContextOptions<LagerDatabase> options) : base(options) { }

        // DbSet-egenskaber for dine entiteter
        public DbSet<Lager_Data> LagerData { get; set; }
    }
}

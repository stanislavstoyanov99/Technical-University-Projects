namespace StorageEngine
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class EngineDbContext : DbContext
    {
        public EngineDbContext() 
            : base("name=EngineDbContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AcEngine> AcEngines { get; set; }
        public virtual DbSet<DcEngine> DcEngines { get; set; }
        public virtual DbSet<Generator> Generators { get; set; }
    }
    
}

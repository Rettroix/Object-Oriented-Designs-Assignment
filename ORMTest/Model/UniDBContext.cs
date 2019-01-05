namespace Model
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public partial class UniDBContext: DbContext
    {
        public UniDBContext () : base("name=UniDatabase")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<UniDBContext,
                                    Model.Migrations.Configuration>("UniDatabase"));

        }
        public DbSet<ClientCompany> ClientCompanys {get; set;}
        public DbSet<Job> Jobs {get; set;}
        public DbSet<Address> Addresses {get; set;}
        public DbSet<Staff> WorkingStaff { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }

}
namespace ItemsReport_Web1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SystemDBContext : DbContext
    {
        public SystemDBContext()
            : base("name=SystemsDB")
        {
        }

        public virtual DbSet<NewPrimaryPosition> NewPrimaryPositions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

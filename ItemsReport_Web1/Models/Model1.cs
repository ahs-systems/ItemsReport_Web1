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
        public virtual DbSet<ItemsReportLetter> ItemsReportLetters { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<PayPeriod> PayPeriods { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

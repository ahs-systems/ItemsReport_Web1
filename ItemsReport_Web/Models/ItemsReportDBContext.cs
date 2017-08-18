using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ItemsReport_Web.Models;

namespace ItemsReport_Web.Models
{
    public class ItemsReportDBContext: DbContext
    {
        public ItemsReportDBContext()
            : base("SystemsDB")
        {
        }

        public DbSet<NewPrimaryPosition> NewPrimaryPositions { get; set; }
    }
}
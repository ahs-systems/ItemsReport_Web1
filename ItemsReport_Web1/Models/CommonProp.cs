using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ItemsReport_Web1
{
    public class ItemsReportLetter
    {
        public int id { get; set; }

        [Required]
        public string desc { get; set; }
    }

    public class Status
    {
        public int id { get; set; }

        [Required]
        public string desc { get; set; }
    }

    public class PayPeriod
    {
        public int id { get; set; }

        [Required]
        public string desc { get; set; }
    }
}
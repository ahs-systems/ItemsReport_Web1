using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace ItemsReport_Web1
{   

    public class NewPrimaryPosition
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string ItemsReportLetter { get; set; }

        public byte PayPeriod { get; set; }

        public short PayPeriod_Year { get; set; }

        public byte Site { get; set; }

        [Required]
        [StringLength(50)]
        public string Emp_Num { get; set; }

        [Required]
        [StringLength(100)]
        public string Emp_Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Unit { get; set; }

        [Required]
        [StringLength(100)]
        public string Occupation { get; set; }

        public DateTime EnteredDate { get; set; }

        [Required]
        [StringLength(100)]
        public string EnteredBy { get; set; }

        [Required]
        [StringLength(10)]
        public string Status { get; set; }
    }
}

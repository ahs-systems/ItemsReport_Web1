using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItemsReport_Web.Models
{
    public class NewPrimaryPosition
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [Display(Name="Items Report Letter")]
        [MaxLength(50)]
        public string ItemsReportLetter { get; set; }

        [Required]        
        public byte PayPeriod { get; set; }

        [Required]
        public Int16 PayPeriod_Year { get; set; }

        [Required]
        public byte Site { get; set; }

        [Required]
        [MaxLength(50)]
        public string Emp_Num { get; set; }

        [Required]
        [MaxLength(100)]
        public string Emp_Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Unit { get; set; }

        [Required]
        [MaxLength(100)]
        public string Occupation { get; set; }

        [Required]
        [MaxLength(10)]
        public string Status { get; set; }

        [Required]
        [MaxLength(100)]
        public string EnteredBy { get; set; }

        [Required]
        public DateTime EnteredDate { get; set; }
    }
}
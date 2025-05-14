using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnada_Appsdev.Models
{
    [Table("EnrollmentDetailFile")]
    public class EnrollmentDetailFile
    {
        [Key, Column(Order = 1)]
        [Required]
        public long ENRDFSTUDID { get; set; } // Student ID (part of composite key)

        [Required, StringLength(15)]
        public string ENRDFSTUDSUBJCDE { get; set; } // Subject Code

        [Key, Column(Order = 2)]
        [Required, StringLength(8)]
        public string ENRDFSTUDEDPCODE { get; set; } // EDPCODE (part of composite key)

        [Required, StringLength(2)]
        public string ENRDFSTUDSTATUS { get; set; } // Withdrawn, Cancelled
    }
}

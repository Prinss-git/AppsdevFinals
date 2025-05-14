using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnada_Appsdev.Models
{
    namespace Parnada_Appsdev.Models
    {
        [Table("SubjectSchedFile")]
        public class SubjectSchedFile
        {
            [Key]
            [Required, StringLength(8)]
            public string SSFEDPCODE { get; set; }

            [Required, StringLength(15)]
            public string SSFSUBJCODE { get; set; }

            [Required]
            public DateTime SSFSTARTTIME { get; set; }

            [Required]
            public DateTime SSFENDTIME { get; set; }

            // Read-only properties to return only the time part
            [NotMapped]
            public string StartTimeOnly => SSFSTARTTIME.ToString("HH:mm:ss"); // 24-hour format

            [NotMapped]
            public string EndTimeOnly => SSFENDTIME.ToString("HH:mm:ss");

            [Required, StringLength(3)]
            public string SSFDAYS { get; set; }

            [Required, StringLength(3)]
            public string SSFROOM { get; set; }

            [Required]
            public int SSFMAXSIZE { get; set; } // Max students allowed

            [Required]
            public int SSFCLASSSIZE { get; set; } // Students who took the subject

            [Required, StringLength(3)]
            public string SSFSTATUS { get; set; } // Active, Inactive, Dissolved, etc.

            [Required, StringLength(3)]
            public string SSFXM { get; set; } // AM/PM

            [Required, StringLength(3)]
            public string SSFSECTION { get; set; }

            [Required]
            public int SSFSCHOOLYEAR { get; set; } // School year
        }
    }
}

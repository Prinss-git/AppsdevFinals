    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnada_Appsdev.Models
{
    public class EnrollmentHeaderFile
    {
        public long ENRHFSTUDID { get; set; } // Student ID (Primary Key)
        public DateTime ENRHFSTUDDATEENROLL { get; set; } // Date Enrolled
        public string ENRHFSTUDSCHLYR { get; set; } // School Year (Max 15 chars)
        public string ENRHFSTUDENCODER { get; set; } // Encoder Name (Max 15 chars)
        public double ENRHFSTUDTOTALUNITS { get; set; } // Total Enrolled Units
        public string ENRHFSTUDSTATUS { get; set; } // Status: Enrolled / Unenrolled
    }
}

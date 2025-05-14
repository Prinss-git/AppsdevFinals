using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnada_Appsdev.Models
{
    public class StudentGradeFile
    {
        [Key, Column(Order = 1)]
        public long SGFSTUDID { get; set; }

        [Required, StringLength(15)]
        public string SGFSTUDSUBJCODE { get; set; }

        public double SGFSTUDSUBJGRADE { get; set; }

        [Key, Column(Order = 2)]
        [Required, StringLength(8)]
        public string SGFSTUDEDPCODE { get; set; }

        [StringLength(10)]
        public string SGFSTUDREMARKS { get; set; }
    }
}

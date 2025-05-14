using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnada_Appsdev.Models
{
    [Table("SubjectPreqFile")]
    public class SubjectPreqFile
    {
        private string _subjCode;
        private string _subjPreCode;
        private string _subjCategory;

        [Key, Column(Order = 1)]
        [Required, StringLength(15)]
        public string SUBJCODE
        {
            get => _subjCode;
            set => _subjCode = value?.ToUpper();
        }

        [Key, Column(Order = 2)]
        [Required, StringLength(15)]
        public string SUBJPRECODE
        {
            get => _subjPreCode;
            set => _subjPreCode = value?.ToUpper();
        }

        [Required, StringLength(2)]
        public string SUBJCATEGORY
        {
            get => _subjCategory;
            set => _subjCategory = value?.ToUpper();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parnada_Appsdev.Models
{
    public class SubjectFile
    {
        private string _sfSubjCode;
        private string _sfSubjDesc;
        private string _sfSubjCurrCode;

        public string SFSUBJCODE
        {
            get => _sfSubjCode;
            set => _sfSubjCode = value?.ToUpper(); // Ensure UpperCase
        }

        public string SFSUBJDESC
        {
            get => _sfSubjDesc;
            set => _sfSubjDesc = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value?.ToLower() ?? ""); // Ensure TitleCase
        }

        public float SFSUBJUNITS { get; set; }

        public int SFSUBJREGOFRNG { get; set; }

        public string SFSUBJCATEGORY { get; set; }

        public string SFSUBJSTATUS { get; set; }

        public string SFSUBJCOURSECODE { get; set; }

        public string SFSUBJCURRCODE
        {
            get => _sfSubjCurrCode;
            set => _sfSubjCurrCode = value?.ToUpper(); // Ensure UpperCase
        }

        public string CompositeKey => $"{SFSUBJCODE}_{SFSUBJCOURSECODE}";
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EduSpire.Models
{
    public enum FormType {
        HighSchool,
        College,
        TechnicalCollege,
        GraduateSchool
    }

    public class FormOption
    {
        public string title { get; set; }
        public string type { get; set; }
    }

    public class FormList
    {
        public string question { get; set; }
        public List<FormOption> options { get; set; }
    }
}
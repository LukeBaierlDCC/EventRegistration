using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventRegistration
{
    class BadgeTemplate
    {
        public int TemplateId { get; set; }
        public string TemplateName { get; set; }
        public List<String> TemplateFields { get; set; }
        public string TemplateDesign { get; set; }
    }
}

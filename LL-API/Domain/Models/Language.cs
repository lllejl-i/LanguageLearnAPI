using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Language
    {
        public LanguageMark LanguageMark { get; set; }
        public string Name { get; set; }
        public IEnumerable<Word>? Words { get; set; }
    }
}

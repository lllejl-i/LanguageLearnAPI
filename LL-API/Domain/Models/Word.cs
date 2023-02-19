using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Word
    {
        public Guid ID { get; set; }
        public string Text { get; set; }
        public LanguageMark LanguageMark { get; set; }
        public Difficulty Difficulty { get; set; }
        public IEnumerable<Guid>? Synonyms { get; set; }
        public IEnumerable<Theme> Themes { get; set; }
    }
}

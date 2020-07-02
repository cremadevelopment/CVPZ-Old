using System;
using System.Collections.Generic;
using System.Text;

namespace CVPZ.Core.Entities
{
    public class JournalEntry
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public List<string> Technologies { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace CVPZ.Core.Entities
{
    public class Job
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset? EndDate { get; set; }
        public IEnumerable<JournalEntry> Journal { get; set; }
    }
}

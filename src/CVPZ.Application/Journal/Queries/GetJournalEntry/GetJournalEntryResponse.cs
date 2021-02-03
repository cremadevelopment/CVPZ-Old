using CVPZ.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVPZ.Application.Journal.Queries.GetJournalEntry
{
    public class GetJournalEntryResponse
    {
        public int JournalEntryId { get; set; }
        public string Description { get; set; }

        public GetJournalEntryResponse(JournalEntry entry)
        {
            JournalEntryId = entry.Id;
            Description = entry.Description;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVPZ.Application.Journal.Commands.CreateJournalEntry
{
    public class CreateJournalEntryResponse
    {
        public int JournalEntryId { get; set; }

        public CreateJournalEntryResponse(int id)
        {
            JournalEntryId = id;
        }
    }
}

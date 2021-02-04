using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVPZ.Application.Journal.Commands.CreateJournalEntry
{
    public class JournalDTO
    {
        public int JournalEntryId { get; set; }

        public JournalDTO(int id)
        {
            JournalEntryId = id;
        }
    }
}

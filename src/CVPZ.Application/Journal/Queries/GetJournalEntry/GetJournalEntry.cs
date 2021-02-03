using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVPZ.Application.Journal.Queries.GetJournalEntry
{
    public class GetJournalEntry : IRequest<GetJournalEntryResponse>
    {
        public int JournalEntryId { get; set; }
    }
}

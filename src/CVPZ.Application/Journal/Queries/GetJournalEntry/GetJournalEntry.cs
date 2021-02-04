using CVPZ.Application.Resume.DataTransferObjects;
using MediatR;

namespace CVPZ.Application.Journal.Queries.GetJournalEntry
{
    public class GetJournalEntry : IRequest<JournalDTO>
    {
        public string JournalEntryId { get; set; }
    }
}

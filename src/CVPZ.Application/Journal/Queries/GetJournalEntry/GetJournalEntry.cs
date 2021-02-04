using CVPZ.Application.Journal.Commands.CreateJournalEntry;
using MediatR;

namespace CVPZ.Application.Journal.Queries.GetJournalEntry
{
    public class GetJournalEntry : IRequest<JournalDTO>
    {
        public string JournalEntryId { get; set; }
    }
}

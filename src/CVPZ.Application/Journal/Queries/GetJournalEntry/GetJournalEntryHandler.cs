using CVPZ.Core.Entities;
using CVPZ.Core.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CVPZ.Application.Journal.Queries.GetJournalEntry
{
    public class GetJournalEntryHandler : IRequestHandler<GetJournalEntry, GetJournalEntryResponse>
    {
        private readonly IRepository<JournalEntry> _journalEntryRepository;

        public GetJournalEntryHandler(IRepository<JournalEntry> journalEntryRepository)
        {
            _journalEntryRepository = journalEntryRepository;
        }

        public async Task<GetJournalEntryResponse> Handle(GetJournalEntry request, CancellationToken cancellationToken)
        {
            var journalEntry = await _journalEntryRepository.GetByIdAsync(request.JournalEntryId);
            return new GetJournalEntryResponse(journalEntry);
        }
    }
}

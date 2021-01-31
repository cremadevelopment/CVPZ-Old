using CVPZ.Core.Entities;
using CVPZ.Core.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CVPZ.Application.Journal.Commands.CreateJournalEntry
{
    public class CreateJournalEntryHandler : IRequestHandler<CreateJournalEntry, CreateJournalEntryResponse>
    {
        private readonly IRepository<JournalEntry> _journalEntryRepository;

        public CreateJournalEntryHandler(IRepository<JournalEntry> journalEntryRepository)
        {
            _journalEntryRepository = journalEntryRepository;
        }

        public async Task<CreateJournalEntryResponse> Handle(CreateJournalEntry request, CancellationToken cancellationToken)
        {
            Thread.Sleep(500);

            var journalEntry = await _journalEntryRepository.AddAsync(request.ToEntity());
            return new CreateJournalEntryResponse(journalEntry.Id);
        }
    }
}

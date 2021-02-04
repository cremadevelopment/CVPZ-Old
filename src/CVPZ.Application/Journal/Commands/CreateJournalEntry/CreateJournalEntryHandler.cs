using AutoMapper;
using CVPZ.Application.Resume.DataTransferObjects;
using CVPZ.Core.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CVPZ.Application.Journal.Commands.CreateJournalEntry
{
    public class CreateJournalEntryHandler : IRequestHandler<CreateJournalEntry, JournalDTO>
    {
        private readonly IJournalRepository _journalRepository;
        private readonly IMapper _mapper;

        public CreateJournalEntryHandler(IJournalRepository journalRepository, IMapper mapper)
        {
            _journalRepository = journalRepository;
            _mapper = mapper;
        }

        public async Task<JournalDTO> Handle(CreateJournalEntry request, CancellationToken cancellationToken)
        {
            Thread.Sleep(500);
            var journal = CVPZ.Domain.Journal.Journal.CreateNewJournalEntry(request.Description);
            var journalId = await _journalRepository.SaveAsync(journal);
            return _mapper.Map<JournalDTO>(journal);
        }
    }
}

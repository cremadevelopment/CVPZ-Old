using AutoMapper;
using CVPZ.Application.Journal.Commands.CreateJournalEntry;
using CVPZ.Application.Resume.DataTransferObjects;
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
    public class GetJournalEntryHandler : IRequestHandler<GetJournalEntry, JournalDTO>
    {
        private readonly IJournalRepository _journalRepository;
        private readonly IMapper _mapper;

        public GetJournalEntryHandler(IJournalRepository journalRepository, IMapper mapper)
        {
            _journalRepository = journalRepository;
            _mapper = mapper;
        }

        public async Task<JournalDTO> Handle(GetJournalEntry request, CancellationToken cancellationToken)
        {
            var journal = await _journalRepository.GetByIdAsync(request.JournalEntryId);
            return _mapper.Map<JournalDTO>(journal);
        }
    }
}

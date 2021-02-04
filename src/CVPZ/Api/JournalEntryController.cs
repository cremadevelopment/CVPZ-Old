using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using MediatR;
using CVPZ.Application.Journal.Commands.CreateJournalEntry;
using CVPZ.Application.Journal.Queries.GetJournalEntry;
using CVPZ.Application.Resume.DataTransferObjects;

namespace CVPZ.Api
{
    public class JournalEntryController : BaseApiController
    {
        private readonly ILogger<JournalEntryController> _logger;
        private readonly IMediator _mediator;

        public JournalEntryController(
            ILogger<JournalEntryController> logger,
            IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<JournalDTO>  Get([FromQuery]string journalId)
        {
            var query = new GetJournalEntry { JournalEntryId = journalId };
            return await _mediator.Send(query);
        }

        [HttpPost("Create")]
        public async Task<JournalDTO> Create(CreateJournalEntry createJournal)
        {
            _logger.LogInformation("Recieved journal entry create request.");
            var response = await _mediator.Send(createJournal);
            return response;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using CVPZ.Application.Service;
using CVPZ.Api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using JournalEntryEntity = CVPZ.Core.Entities.JournalEntry;

namespace CVPZ.Api
{
    public class JournalEntryController : BaseApiController
    {
        private readonly ILogger<JournalEntryController> _logger;
        private readonly IJournalService _journalService;

        public JournalEntryController(
            ILogger<JournalEntryController> logger,
            IJournalService journalService)
        {
            _logger = logger;
            _journalService = journalService;
        }

        [HttpGet]
        public async Task<IEnumerable<JournalEntry>> Get()
        {
            _logger.LogInformation("Recieved journal entry request.");
            var journalEntries
                = (await _journalService.GetAsync())
                    .Select(x => JournalEntry.FromEntity(x));
            return journalEntries;
        }

        [HttpGet("{id:int}")]
        public async Task<JournalEntry> GetById(int id)
        {
            _logger.LogInformation("Recieved journal entry get request.");
            var entry = await _journalService.GetByIdAsync(id);
            return JournalEntry.FromEntity(entry);
        }

        [HttpPost]
        public async Task<JournalEntry> Post(JournalEntry journalEntry)
        {
            _logger.LogInformation("Recieved journal entry create request.");
            var entry = new JournalEntryEntity()
            {
                Description = journalEntry.Description
            };
            await _journalService.AddAsync(entry);
            return JournalEntry.FromEntity(entry);
        }
    }
}

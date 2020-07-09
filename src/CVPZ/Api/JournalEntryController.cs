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

        [HttpPost]
        public async Task<JournalEntry> Post(JournalEntry journalEntry)
        {
            var entry = new JournalEntryEntity()
            {
                Description = journalEntry.Description,
                Technologies = journalEntry.Technologies
            };
            await _journalService.AddAsync(entry);
            return JournalEntry.FromEntity(entry);
        }
    }
}

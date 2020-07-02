using System;
using System.Collections.Generic;
using System.Linq;
using CVPZ.Application.Service;
using CVPZ.Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CVPZ.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JournalEntryController : ControllerBase
    {
        private readonly ILogger<JournalEntryController> _logger;
        private readonly IJournalService _journalService;

        public JournalEntryController(ILogger<JournalEntryController> logger, IJournalService journalService)
        {
            _logger = logger;
            _journalService = journalService;
        }

        [HttpGet]
        public IEnumerable<JournalEntry> Get()
        {
            _logger.LogInformation("Recieved journal entry request.");
            return _journalService.Get();
        }
    }
}

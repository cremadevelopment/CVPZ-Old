using CVPZ.Core.Entities;
using CVPZ.Core.Repository;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVPZ.Application.Service
{
    public interface IJournalService
    {
        Task<IEnumerable<JournalEntry>> GetAsync();
        Task<JournalEntry> AddAsync(JournalEntry entry);
        Task<JournalEntry> GetByIdAsync(int id);
    }

    public class JournalService : IJournalService
    {

        private readonly ILogger<JournalService> _logger;
        private readonly IRepository<JournalEntry> _journalEntryRepository;

        public JournalService(ILogger<JournalService> logger, IRepository<JournalEntry> journalEntryRepository)
        {
            _logger = logger;
            _journalEntryRepository = journalEntryRepository;
        }

        public async Task<IEnumerable<JournalEntry>> GetAsync()
        {
            _logger.LogInformation("Service request recieved journal entry request.");
            return await _journalEntryRepository.ListAsync();
        }

        public async Task<JournalEntry> GetByIdAsync(int id)
        {
            _logger.LogInformation("Service request recieved to get journal entry by id.");
            return await _journalEntryRepository.GetByIdAsync(id);

        }

        public async Task<JournalEntry> AddAsync(JournalEntry entry)
        {
            _logger.LogInformation("Service request recieved to create journal entry.");
            return await _journalEntryRepository.AddAsync(entry);
        }
    }
}

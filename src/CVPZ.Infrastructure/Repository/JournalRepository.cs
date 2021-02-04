using CVPZ.Core.Repository;
using CVPZ.Domain.Journal;
using System.Threading.Tasks;
using Tactical.DDD.EventSourcing;

namespace CVPZ.Infrastructure.Repository
{
    public class JournalRepository : IJournalRepository
    {
        private readonly IEventStore _eventStore;

        public JournalRepository(IEventStore eventStore)
        {
            _eventStore = eventStore;
        }

        public async Task<Journal> GetByIdAsync(string id)
        {
            var @events = await _eventStore.LoadEventsAsync(new JournalId(id));
            return new Journal(events);
        }

        public async Task<JournalId> SaveAsync(Journal journal)
        {
            await _eventStore.SaveEventsAsync(journal.Id, journal.Version, journal.DomainEvents);
            return journal.Id;
        }
    }
}

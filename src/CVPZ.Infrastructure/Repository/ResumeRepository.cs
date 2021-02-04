using CVPZ.Core.Repository;
using CVPZ.Domain.Resume;
using System.Threading.Tasks;
using Tactical.DDD.EventSourcing;

namespace CVPZ.Infrastructure.Repository
{
    public class ResumeRepository : IResumeRepository
    {
        private readonly IEventStore _eventStore;

        public ResumeRepository(IEventStore eventStore)
        {
            _eventStore = eventStore;
        }

        public async Task<Resume> GetById(string id)
        {
            var resumeEvents = await _eventStore.LoadEventsAsync(new ResumeId(id));
            return new Resume(resumeEvents);
        }

        public async Task<ResumeId> SaveAsync(Resume resume)
        {
            await _eventStore.SaveEventsAsync(resume.Id, resume.Version, resume.DomainEvents);
            return resume.Id;
        }
    }
}

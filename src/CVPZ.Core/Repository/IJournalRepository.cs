using CVPZ.Domain.Journal;
using System.Threading.Tasks;

namespace CVPZ.Core.Repository
{
    public interface IJournalRepository
    {
        Task<Journal> GetByIdAsync(string id);
        Task<JournalId> SaveAsync(Journal journal);
    }
}

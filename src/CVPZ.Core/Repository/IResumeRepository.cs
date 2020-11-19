using CVPZ.Domain.Resume;
using System.Threading.Tasks;

namespace CVPZ.Core.Repository
{
    public interface IResumeRepository
    {

        Task<Resume> GetById(string id);
        Task<ResumeId> SaveAsync(Resume resume);
    }
}

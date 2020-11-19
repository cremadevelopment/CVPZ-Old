using CVPZ.Domain.Resume;

namespace CVPZ.Application.Resume
{
    public class CreateResumeResponse
    {
        public ResumeId ResumeId { get; set; }

        public CreateResumeResponse(ResumeId id)
        {
            this.ResumeId = id;
        }
    }
}

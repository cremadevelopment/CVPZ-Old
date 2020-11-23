using CVPZ.Domain.Resume;
using System;

namespace CVPZ.Application.Resume.Commands.CreateResume
{
    public class CreateResumeResponse
    {
        public string ResumeId { get; set; }

        public CreateResumeResponse(ResumeId id)
        {
            this.ResumeId = id.ToString();
        }
    }
}

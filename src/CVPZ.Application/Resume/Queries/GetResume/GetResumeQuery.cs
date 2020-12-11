using CVPZ.Application.Resume.DataTransferObjects;
using MediatR;

namespace CVPZ.Application.Resume.Queries.GetResume
{
    public class GetResumeQuery : IRequest<ResumeDTO>
    {
        public string ResumeId { get; set; }
    }
}
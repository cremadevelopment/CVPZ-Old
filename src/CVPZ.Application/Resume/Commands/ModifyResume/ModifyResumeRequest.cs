using CVPZ.Application.Resume.DataTransferObjects;
using MediatR;

namespace CVPZ.Application.Resume.Commands.ModifyResume
{
    public class ModifyResume : IRequest<ResumeDTO>
    {
        public string ResumeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

using CVPZ.Application.Resume.DataTransferObjects;
using MediatR;
using System.Collections.Generic;
using System.Text;

namespace CVPZ.Application.Resume.Commands.CreateResume
{
    public class CreateResume : IRequest<ResumeDTO>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

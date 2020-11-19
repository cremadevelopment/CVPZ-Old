using MediatR;
using System.Collections.Generic;
using System.Text;

namespace CVPZ.Application.Resume
{
    public class CreateResume : IRequest<CreateResumeResponse>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

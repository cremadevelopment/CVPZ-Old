using CVPZ.Core.Repository;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CVPZ.Application.Resume.Commands.CreateResume
{
    public class CreateResumeHandler : IRequestHandler<CreateResume, CreateResumeResponse>
    {
        private readonly IResumeRepository _resumeRepository;

        public CreateResumeHandler(IResumeRepository resumeRepository)
        {
            _resumeRepository = resumeRepository;
        }

        public async Task<CreateResumeResponse> Handle(CreateResume request, CancellationToken cancellationToken)
        {
            Thread.Sleep(500);
            var resume = CVPZ.Domain.Resume.Resume.CreateNewResume(request.FirstName, request.LastName);
            var resumeId = await _resumeRepository.SaveAsync(resume);
            return new CreateResumeResponse(resumeId);
        }
    }
}

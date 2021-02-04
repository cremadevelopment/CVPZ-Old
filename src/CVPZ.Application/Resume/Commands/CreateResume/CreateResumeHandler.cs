using AutoMapper;
using CVPZ.Application.Resume.DataTransferObjects;
using CVPZ.Core.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CVPZ.Application.Resume.Commands.CreateResume
{
    public class CreateResumeHandler : IRequestHandler<CreateResume, ResumeDTO>
    {
        private readonly IResumeRepository _resumeRepository;
        private readonly IMapper _mapper;

        public CreateResumeHandler(IResumeRepository resumeRepository, IMapper mapper)
        {
            _resumeRepository = resumeRepository;
            _mapper = mapper;
        }

        public async Task<ResumeDTO> Handle(CreateResume request, CancellationToken cancellationToken)
        {
            Thread.Sleep(500);
            var resume = CVPZ.Domain.Resume.Resume.CreateNewResume(request.FirstName, request.LastName);
            var resumeId = await _resumeRepository.SaveAsync(resume);
            return _mapper.Map<ResumeDTO>(resume);
        }
    }
}

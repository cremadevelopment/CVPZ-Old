using AutoMapper;
using CVPZ.Application.Resume.DataTransferObjects;
using CVPZ.Core.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CVPZ.Application.Resume.Commands.ModifyResume
{
    public class ModifyResumeHandler : IRequestHandler<ModifyResume, ResumeDTO>
    {
        private readonly IResumeRepository _repository;
        private readonly IMapper _mapper;

        public ModifyResumeHandler(IResumeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ResumeDTO> Handle(ModifyResume request, CancellationToken cancellationToken)
        {
            var resume = await _repository.GetById(request.ResumeId.ToString());
            resume.ModifyResume(request.FirstName, request.LastName);
            await _repository.SaveAsync(resume);
            return _mapper.Map<ResumeDTO>(resume);
        }
    }
}

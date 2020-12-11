using AutoMapper;
using CVPZ.Application.Resume.DataTransferObjects;
using CVPZ.Core.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CVPZ.Application.Resume.Queries.GetResume
{
    public class GetResumeQueryHandler : IRequestHandler<GetResumeQuery, ResumeDTO>
    {
        private readonly IResumeRepository _repository;
        private readonly IMapper _mapper;

        public GetResumeQueryHandler(IResumeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ResumeDTO> Handle(GetResumeQuery request, CancellationToken cancellationToken)
        {
            var resume = await _repository.GetById(request.ResumeId);
            return _mapper.Map<ResumeDTO>(resume);
        }
    }
}

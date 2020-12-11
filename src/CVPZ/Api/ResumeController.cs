using CVPZ.Application.Resume;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using MediatR;
using CVPZ.Application.Resume.Commands.CreateResume;
using CVPZ.Application.Resume.DataTransferObjects;
using CVPZ.Application.Resume.Queries.GetResume;

namespace CVPZ.Api
{
    public class ResumeController : BaseApiController
    {
        private readonly ILogger<ResumeController> _logger;
        private readonly IMediator _mediator;

        public ResumeController(ILogger<ResumeController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ResumeDTO> Get([FromQuery] string resumeId)
        {
            var query = new GetResumeQuery { ResumeId = resumeId };
            return await _mediator.Send(query);
        }

        [HttpPost("Create")]
        public async Task<CreateResumeResponse> Create(CreateResume createResume)
        {
            _logger.LogInformation("Recieved create resume request.");
            var response = await _mediator.Send(createResume);
            return response;
        }

        //[HttpPost("{resumeId}")]
        //public async Task<UpdateResumeResponse> Update([FromQuery]string resumeId, UpdateResume resume)
        //{
        //    _logger.LogInformation("Recieved create resume request.");
        //    var response = await _mediator.Send(resume);
        //    return response;
        //}
    }
}

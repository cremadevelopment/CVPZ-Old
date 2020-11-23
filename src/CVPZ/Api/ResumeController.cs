using CVPZ.Application.Resume;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using MediatR;

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

        [HttpPost("Create")]
        public async Task<CreateResumeResponse> Create(CreateResume createResume)
        {
            _logger.LogInformation("Recieved create resume request.");
            var response = await _mediator.Send(createResume);
            return response;
        }

        [HttpPost("{resumeId}")]
        public async Task<UpdateResumeResponse> Update([FromQuery]string resumeId, UpdateResume resume)
        {
            _logger.LogInformation("Recieved create resume request.");
            var response = await _mediator.Send(resume);
            return response;
        }
    }
}

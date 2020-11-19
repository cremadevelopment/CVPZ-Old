using CVPZ.Application.Resume;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace CVPZ.Api
{
    public class ResumeController : BaseApiController
    {
        private readonly ILogger<ResumeController> _logger;

        public ResumeController(ILogger<ResumeController> logger)
        {
            _logger = logger;
        }

        [HttpPost("Create")]
        public async Task<CreateResumeResponse> Create(CreateResume createResume)
        {
            _logger.LogInformation("Recieved create resume request.");
            throw new NotImplementedException("");
        }

        [HttpPost("Update/{resumeId}")]
        public async Task<UpdateResumeResponse> Update([FromQuery]string resumeId, UpdateResume createResume)
        {
            _logger.LogInformation("Recieved create resume request.");
            throw new NotImplementedException("");
        }
    }
}

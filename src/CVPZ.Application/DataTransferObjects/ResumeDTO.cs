using AutoMapper;
using CVPZ.Application.Mappings;

namespace CVPZ.Application.Resume.DataTransferObjects
{
    public class ResumeDTO : IMapFrom<CVPZ.Domain.Resume.Resume>
    {
        public string ResumeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CVPZ.Domain.Resume.Resume, ResumeDTO>()
                .ForMember(d => d.ResumeId, opt => opt.MapFrom(s => s.Id));
        }
    }
}

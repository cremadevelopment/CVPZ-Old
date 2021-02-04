using AutoMapper;
using CVPZ.Application.Mappings;

namespace CVPZ.Application.Resume.DataTransferObjects
{
    public class JournalDTO : IMapFrom<CVPZ.Domain.Journal.Journal>
    {
        public string JournalId { get; set; }
        public string Description { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CVPZ.Domain.Journal.Journal, JournalDTO>()
                .ForMember(d => d.JournalId, opt => opt.MapFrom(s => s.Id));
        }
    }
}

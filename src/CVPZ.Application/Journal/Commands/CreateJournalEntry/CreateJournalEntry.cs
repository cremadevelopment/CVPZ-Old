using CVPZ.Application.Resume.DataTransferObjects;
using MediatR;

namespace CVPZ.Application.Journal.Commands.CreateJournalEntry
{
    public class CreateJournalEntry : IRequest<JournalDTO>
    {
        public string Description { get; set; }
    }
}

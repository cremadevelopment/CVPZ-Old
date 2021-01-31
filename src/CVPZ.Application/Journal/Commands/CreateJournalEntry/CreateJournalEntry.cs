using CVPZ.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVPZ.Application.Journal.Commands.CreateJournalEntry
{
    public class CreateJournalEntry : IRequest<CreateJournalEntryResponse>
    {
        public string Description { get; set; }

        public JournalEntry ToEntity()
        {
            return new JournalEntry
            {
                Description = Description
            };
        }
    }
}

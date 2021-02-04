using System;
using System.Collections.Generic;
using System.Text;
using Tactical.DDD;

namespace CVPZ.Domain.Journal.Events
{
    public class JournalCreated : IDomainEvent
    {
        public JournalCreated(string id, string description)
        {
            Id = id;
            Description = description;
            CreatedAt = DateTime.Now;
        }

        public string Id { get; private set; }
        public string Description { get; private set; }

        public DateTime CreatedAt { get; set; }
    }
}

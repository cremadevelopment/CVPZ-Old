using System;
using System.Collections.Generic;
using Tactical.DDD;

namespace CVPZ.Domain.Resume.Events
{
    public class ResumeCreated : IDomainEvent
    {

        public ResumeCreated(string id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            CreatedAt = DateTime.Now;
        }

        public string Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public DateTime CreatedAt { get; set; }
    }
}
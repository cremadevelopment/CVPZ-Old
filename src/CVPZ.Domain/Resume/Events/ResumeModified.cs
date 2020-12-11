using System;
using Tactical.DDD;

namespace CVPZ.Domain.Resume.Events
{
    public class ResumeModified : IDomainEvent
    {
        public ResumeModified(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            CreatedAt = DateTime.Now;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime CreatedAt { get; set; }
    }
}
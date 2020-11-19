using CVPZ.Domain.Resume.Events;
using System;
using System.Collections.Generic;
using System.Text;
using Tactical.DDD;

namespace CVPZ.Domain.Resume
{
    public class Resume : Tactical.DDD.EventSourcing.AggregateRoot<ResumeId>
    {
        public override ResumeId Id { get; protected set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Resume(IEnumerable<IDomainEvent> events) : base(events)
        { }

        private Resume()
        { }

        public static Resume CreateNewResume(
            string firstName,
            string lastName)
        {

            var resume = new Resume();
            resume.Apply(new ResumeCreated(new ResumeId().ToString(), firstName, lastName));

            return resume;
        }

        public void On(ResumeCreated @event)
        {
            Id = new ResumeId(@event.Id);
            FirstName = @event.FirstName;
            LastName = @event.LastName;
        }

    }
}

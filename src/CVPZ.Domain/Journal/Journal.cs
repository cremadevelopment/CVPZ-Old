using CVPZ.Domain.Journal.Events;
using System;
using System.Collections.Generic;
using System.Text;
using Tactical.DDD;

namespace CVPZ.Domain.Journal
{
    public class Journal : Tactical.DDD.EventSourcing.AggregateRoot<JournalId>
    {
        public override JournalId Id { get; protected set; }
        public string Description { get; private set; }

        public Journal(IEnumerable<IDomainEvent> events) : base(events)
        { }

        private Journal() { }

        public static Journal CreateNewJournalEntry(string description)
        {
            var journal = new Journal();
            var @event = new JournalCreated(new JournalId().ToString(), description);
            journal.Apply(@event);

            return journal;
        }

        public void On(JournalCreated @event)
        {
            Id = new JournalId(@event.Id);
            Description = @event.Description;
        }
    }
}

using System;
using Tactical.DDD;

namespace CVPZ.Domain.Journal
{
    public class JournalId : EntityId
    {
        private Guid _guid;

        public JournalId()
        {
            _guid = Guid.NewGuid();
        }

        public JournalId(string id)
        {
            _guid = Guid.Parse(id);
        }

        public override string ToString() => _guid.ToString();
    }
}
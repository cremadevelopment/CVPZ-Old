using System;
using Tactical.DDD;

namespace CVPZ.Domain.Resume
{
    public class ResumeId : EntityId
    {
        private Guid _guid;

        public ResumeId()
        {
            _guid = Guid.NewGuid();
        }

        public ResumeId(string id)
        {
            _guid = Guid.Parse(id);
        }

        public override string ToString() => _guid.ToString();
    }
}

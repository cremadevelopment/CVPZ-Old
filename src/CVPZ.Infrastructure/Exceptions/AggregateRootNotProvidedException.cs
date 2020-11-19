using System;
using System.Collections.Generic;
using System.Text;

namespace CVPZ.Infrastructure.Exceptions
{
    public class AggregateRootNotProvidedException : Exception
    {
        public AggregateRootNotProvidedException(string message) : base(message)
        {

        }

    }
}

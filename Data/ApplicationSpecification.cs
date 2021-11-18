using System;
using System.Collections.Generic;

namespace MessageMocker.Data
{
    internal class ApplicationSpecification
    {
        public Guid Identifier { get; set; }

        public string Name { get; set; }

        public ICollection<EventSpecification> Events { get; set; }

        public ICollection<CommandSpecification> Commands { get; set; }

    }
}

using System;
using System.Collections.Generic;

namespace MessageMocker.Data
{
    public class ApplicationSpecification
    {
        public Guid Identifier { get; set; }

        public string Name { get; set; }

        public string Channel { get; set; } 

        public ICollection<EventSpecification> Events { get; set; }

        public ICollection<CommandSpecification> Commands { get; set; }

    }
}

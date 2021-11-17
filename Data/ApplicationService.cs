using System;
using System.Collections.Generic;

namespace MessageMocker.Data
{
    internal class ApplicationService
    {
        public ICollection<Application> Applications()
        {
            return new List<Application>()
            {
                new Application()
                {
                    Name = "Prova 1",
                    Description = "Sends commands",
                    Identifier = Guid.NewGuid(),
                },
                new Application()
                {
                    Identifier = Guid.NewGuid(),
                    Name = "Prova 2",
                    Description = "publishes events",
                },
                new Application()
                {
                    Identifier = Guid.NewGuid(),
                    Name = "Prova 3",
                    Description = "Test locale",
                },
            }; 
        }
    }
}

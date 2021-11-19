using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace MessageMocker.Data
{
    public  class ApplicationService
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


        public async Task<ApplicationSpecification> ApplicationSpecification(Guid id)
        {

            return new ApplicationSpecification()
            {
                Identifier = id,
                Name = "Prova",
                Commands = new CommandSpecification[]
                {
                    new CommandSpecification()
                    {
                        Name = "ServiziCgn.Imu.BackOffice.Events.Public.CasoImpositivoImuCgnCreato",
                        Sample = "{\"AnnoImposta\": 0,\"CodiceComune\": \"string\",\"IdCasoImpositivo\": 0,\"EventId\": \"219a0dfb-2d03-431e-be28-19bdc45be724\",  \"CorrelationId\": \"09889a02-17d9-4ce4-a60a-3c3cb923fedd\",  \"OriginatorId\": \"34c2c04d-4a6d-4636-8c90-f5f69e069d4d\",  \"TimeStamp\": \"2019-08-24T14:15:22Z\",  \"CurrentUserId\": {}}"
                    }
                },

                Events = new EventSpecification[]
                {
                    new EventSpecification()
                    {
                        Name = "ServiziCgn.Imu.BackOffice.Events.Public.CasoImpositivoImuCgnSostituito",
                        Sample = "{\"AnnoImposta\": 0,\"CodiceComune\": \"string\",\"IdCasoImpositivo\": 0,\"EventId\": \"219a0dfb-2d03-431e-be28-19bdc45be724\",  \"CorrelationId\": \"09889a02-17d9-4ce4-a60a-3c3cb923fedd\",  \"OriginatorId\": \"34c2c04d-4a6d-4636-8c90-f5f69e069d4d\",  \"TimeStamp\": \"2019-08-24T14:15:22Z\",  \"CurrentUserId\": {}}"
                    }
                },
            };
        }
    }
}

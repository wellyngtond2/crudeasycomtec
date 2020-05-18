using CrudNetAngular.Core.Models;
using System;
using System.Collections.Generic;

namespace CrudNetAngular.Data.Initial_Seed
{
    public static class OccupationSeed
    {
        public static List<Occupation> GetOccupationsSeed()
        {
            return new List<Occupation>(){  new Occupation { Id = Guid.NewGuid(), Description = "Up to 4 hours per day / Até 4 horas por dia" , CreatedAt = DateTime.Now },
                                           new Occupation { Id = Guid.NewGuid(), Description = "4 to 6 hours per day / De 4 á 6 horas por dia" , CreatedAt = DateTime.Now },
                                           new Occupation { Id = Guid.NewGuid(), Description = "6 to 8 hours per day /De 6 á 8 horas por dia" , CreatedAt = DateTime.Now },
                                           new Occupation { Id = Guid.NewGuid(), Description = "Up to 8 hours a day (are you sure?) / Acima de 8 horas por dia (tem certeza?)" , CreatedAt = DateTime.Now },
                                           new Occupation { Id = Guid.NewGuid(), Description = "Only weekends / Apenas finais de semana" , CreatedAt = DateTime.Now },
                                           new Occupation { Id = Guid.NewGuid(), Description = "Morning (from 08:00 to 12:00) / Manhã (de 08:00 ás 12:00)" , CreatedAt = DateTime.Now },
                                           new Occupation { Id = Guid.NewGuid(), Description = "Afternoon (from 1:00 p.m. to 6:00 p.m.) / Tarde (de 13:00 ás 18:00)" , CreatedAt = DateTime.Now },
                                           new Occupation { Id = Guid.NewGuid(), Description = "Night (7:00 p.m. to 10:00 p.m.) /Noite (de 19:00 as 22:00)" , CreatedAt = DateTime.Now },
                                           new Occupation { Id = Guid.NewGuid(), Description = "Dawn (from 10 p.m. onwards) / Madrugada (de 22:00 em diante)" , CreatedAt = DateTime.Now },
                                           new Occupation { Id = Guid.NewGuid(), Description = "Business (from 08:00 a.m. to 06:00 p.m.) / Comercial (de 08:00 as 18:00)" , CreatedAt = DateTime.Now }};
        }
    }
}

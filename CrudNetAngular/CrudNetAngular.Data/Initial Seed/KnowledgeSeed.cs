using CrudNetAngular.Core.Models;
using System;
using System.Collections.Generic;

namespace CrudNetAngular.Data.Initial_Seed
{
    public static class KnowledgeSeed
    {
        public static List<Knowledge> GetKnowledgesSeed()
        {
            return new List<Knowledge>(){  new Knowledge { Id = Guid.NewGuid(), Description = "Ionic" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "ReactJS" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "React Native" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Android" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Flutter" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "SWIFT" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "IOS" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "HTML" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "CSS" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Bootstrap" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Jquery" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "AngularJs 1.*" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Angular" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Java" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Python" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Flask" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Asp.Net MVC" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Asp.Net WebForm" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "C" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "C#" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "NodeJS" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Express - NodeJs" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Cake" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Django" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Majento" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "PHP" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Vue" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Wordpress" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Phyton" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Ruby" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "My SQL Server" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "My SQL" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Salesforce" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Photoshop" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Illustrator" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "SEO" , CreatedAt = DateTime.Now },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Laravel" , CreatedAt = DateTime.Now } };
        }
    }
}

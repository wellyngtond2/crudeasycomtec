using CrudNetAngular.Core.Models;
using System;
using System.Collections.Generic;

namespace CrudNetAngular.Data.Initial_Seed
{
    public static class KnowledgeSeed
    {
        public static List<Knowledge> GetKnowledgesSeed()
        {
            return new List<Knowledge>(){  new Knowledge { Id = Guid.NewGuid(), Description = "Ionic" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "ReactJS" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "React Native" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Android" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Flutter" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "SWIFT" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "IOS" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "HTML" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "CSS" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Bootstrap" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Jquery" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "AngularJs 1.*" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Angular" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Java" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Python" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Flask" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Asp.Net MVC" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Asp.Net WebForm" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "C" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "C#" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "NodeJS" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Express - NodeJs" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Cake" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Django" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Majento" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "PHP" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Vue" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Wordpress" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Phyton" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Ruby" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "My SQL Server" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "My SQL" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Salesforce" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Photoshop" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Illustrator" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "SEO" },
                                           new Knowledge { Id = Guid.NewGuid(), Description = "Laravel" } };
        }
    }
}

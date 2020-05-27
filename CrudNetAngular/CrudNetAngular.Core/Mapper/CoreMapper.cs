using AutoMapper;
using CrudNetAngular.Core.Models;
using CrudNetAngular.DataContracts.Request;
using CrudNetAngular.DataContracts.Request.TalentBase;
using CrudNetAngular.DataContracts.Response;

namespace CrudNetAngular.Core.Mapper
{
    public sealed class CoreMapper : Profile
    {
        public CoreMapper()
        {
            TalentBase();
        }

        private void TalentBase()
        {
            //Request
            CreateMap<CreateTalentBaseRequest, TalentBase>();
            CreateMap<DeveloperRequest, Developer>();
            CreateMap<KnowledgeRequest, Knowledge>();
            CreateMap<OccupationRequest, Occupation>();

            //Response
            CreateMap<TalentBase, TalentBaseResponse>();
            CreateMap<Developer, DeveloperResponse>();
            CreateMap<Knowledge, KnowledgeResponse>();
            CreateMap<Occupation, OccupationResponse>();
        }
    }
}

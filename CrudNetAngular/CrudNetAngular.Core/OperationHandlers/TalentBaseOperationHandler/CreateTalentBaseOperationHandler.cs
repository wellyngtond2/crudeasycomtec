using AutoMapper;
using CrudNetAngular.Core.Interfaces.Repositories.UoW;
using CrudNetAngular.Core.Interfaces.Validates;
using CrudNetAngular.Core.Models;
using CrudNetAngular.DataContracts.Request.TalentBase;
using CrudNetAngular.DataContracts.Response;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrudNetAngular.Core.Services
{
    public class CreateTalentBaseOperationHandler : BaseOperationHandler<CreateTalentBaseRequest, TalentBaseResponse>
    {
        public CreateTalentBaseOperationHandler(IUnitOfWork unitOfWork,
                                IBaseValidate<CreateTalentBaseRequest> validate,
                                IMapper mapper,
                                ILogger<CreateTalentBaseOperationHandler> logger) : base(unitOfWork, validate, mapper, logger)
        {

        }

        protected async override Task<TalentBaseResponse> ProcessAsync(CreateTalentBaseRequest request)
        {
            var talentBase = _mapper.Map<TalentBase>(request);

            foreach (var req in request.Knowledges)
            {
                talentBase.TalentBaseXKnowledge.Add(new TalentBaseXKnowledge()
                {
                    Level = req.Level,
                    KnowledgeId = req.Id
                });
            }

            foreach (var req in request.Occupations)
            {
                talentBase.TalentBaseXOccupation.Add(new TalentBaseXOccupation()
                {
                    OccupationId = req.Id,
                });
            }

            await _unitOfWork.TalentBaseRepository.Add(talentBase);

            return _mapper.Map<TalentBaseResponse>(talentBase);
        }
    }
}

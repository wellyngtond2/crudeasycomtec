using AutoMapper;
using CrudNetAngular.Core.Interfaces.Repositories.UoW;
using CrudNetAngular.Core.Interfaces.Validates;
using CrudNetAngular.Core.Models;
using CrudNetAngular.DataContracts.Request.TalentBase;
using CrudNetAngular.DataContracts.Response;
using CrudNetAngular.Infra.Extensions;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace CrudNetAngular.Core.Services
{
    public class UpdateTalentBaseOperationHandler : BaseOperationHandler<UpdateTalentBaseRequest, TalentBaseResponse>
    {
        public UpdateTalentBaseOperationHandler(IUnitOfWork unitOfWork,
                                IBaseValidate<UpdateTalentBaseRequest> validate,
                                IMapper mapper,
                                ILogger<UpdateTalentBaseOperationHandler> logger) : base(unitOfWork, validate, mapper, logger)
        {

        }

        protected async override Task<TalentBaseResponse> ProcessAsync(UpdateTalentBaseRequest request)
        {
            var talentBase = await _unitOfWork.TalentBaseRepository.GetById(request.Id);
            var talentBaseUpdate = talentBase.Clone();

            _mapper.Map(request, talentBaseUpdate);

            foreach (var req in request.Knowledges)
            {
                talentBaseUpdate.TalentBaseXKnowledge.Add(new TalentBaseXKnowledge()
                {
                    Level = req.Level,
                    KnowledgeId = req.Id
                });
            }

            foreach (var req in request.Occupations)
            {
                talentBaseUpdate.TalentBaseXOccupation.Add(new TalentBaseXOccupation()
                {
                    OccupationId = req.Id,
                });
            }

            await _unitOfWork.TalentBaseRepository.Update(talentBaseUpdate);

            return _mapper.Map<TalentBaseResponse>(talentBaseUpdate);
        }
    }
}

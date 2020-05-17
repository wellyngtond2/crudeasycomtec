using AutoMapper;
using CrudNetAngular.Core.DataContracts.Request.TalentBase;
using CrudNetAngular.Core.DataContracts.Response;
using CrudNetAngular.Core.Interfaces.Repositories.UoW;
using CrudNetAngular.Core.Interfaces.Validates;
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
                                ILogger logger) : base(unitOfWork, validate, mapper, logger)
        {

        }

        protected async override Task<TalentBaseResponse> ProcessAsync(UpdateTalentBaseRequest request)
        {
            var talentBase = await _unitOfWork.TalentBaseRepository.GetById(request.Id);
            var talentBaseUpdate = talentBase.Clone();

            _mapper.Map(request, talentBaseUpdate);

            await _unitOfWork.TalentBaseRepository.Update(talentBaseUpdate);

            return _mapper.Map<TalentBaseResponse>(talentBaseUpdate);
        }
    }
}

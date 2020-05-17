using AutoMapper;
using CrudNetAngular.Core.DataContracts.Request.TalentBase;
using CrudNetAngular.Core.DataContracts.Response;
using CrudNetAngular.Core.Interfaces.Repositories.UoW;
using CrudNetAngular.Core.Interfaces.Validates;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace CrudNetAngular.Core.Services
{
    public class GetTalentBaseOperationHandler : BaseOperationHandler<GetTalentBaseRequest, TalentBaseResponse>
    {
        public GetTalentBaseOperationHandler(IUnitOfWork unitOfWork,
                                IBaseValidate<GetTalentBaseRequest> validate,
                                IMapper mapper,
                                ILogger logger) : base(unitOfWork, validate, mapper, logger)
        {

        }

        protected async override Task<TalentBaseResponse> ProcessAsync(GetTalentBaseRequest request)
        {
            var talentBase = await _unitOfWork.TalentBaseRepository.GetById(request.Id);

            return _mapper.Map<TalentBaseResponse>(talentBase);
        }
    }
}

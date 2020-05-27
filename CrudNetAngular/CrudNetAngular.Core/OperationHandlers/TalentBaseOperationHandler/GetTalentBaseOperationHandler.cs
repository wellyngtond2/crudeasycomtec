using AutoMapper;
using CrudNetAngular.Core.Interfaces.Repositories.UoW;
using CrudNetAngular.Core.Interfaces.Validates;
using CrudNetAngular.DataContracts.Request.TalentBase;
using CrudNetAngular.DataContracts.Response;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace CrudNetAngular.Core.Services
{
    public class GetTalentBaseOperationHandler : BaseOperationHandler<GetTalentBaseRequest, TalentBaseResponse>
    {
        public GetTalentBaseOperationHandler(IUnitOfWork unitOfWork,
                                IBaseValidate<GetTalentBaseRequest> validate,
                                IMapper mapper,
                                ILogger<GetTalentBaseOperationHandler> logger) : base(unitOfWork, validate, mapper, logger)
        {

        }

        protected async override Task<TalentBaseResponse> ProcessAsync(GetTalentBaseRequest request)
        {
            var talentBase = await _unitOfWork.TalentBaseRepository.GetById(request.Id);

            return _mapper.Map<TalentBaseResponse>(talentBase);
        }
    }
}

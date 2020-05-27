using AutoMapper;
using CrudNetAngular.Core.Interfaces.Repositories.UoW;
using CrudNetAngular.Core.Interfaces.Validates;
using CrudNetAngular.Core.Models;
using CrudNetAngular.DataContracts.Request.TalentBase;
using CrudNetAngular.DataContracts.Response;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace CrudNetAngular.Core.Services
{
    public class DeleteTalentBaseOperationHandler : BaseOperationHandler<DeleteTalentBaseRequest, TalentBaseResponse>
    {
        public DeleteTalentBaseOperationHandler(IUnitOfWork unitOfWork,
                                IBaseValidate<DeleteTalentBaseRequest> validate,
                                IMapper mapper,
                                ILogger<DeleteTalentBaseOperationHandler> logger) : base(unitOfWork, validate, mapper, logger)
        {

        }

        protected async override Task<TalentBaseResponse> ProcessAsync(DeleteTalentBaseRequest request)
        {
            var talentBase = _mapper.Map<TalentBase>(request);
            await _unitOfWork.TalentBaseRepository.Delete(talentBase);

            return _mapper.Map<TalentBaseResponse>(talentBase);
        }
    }
}

using AutoMapper;
using CrudNetAngular.Core.DataContracts.Request.TalentBase;
using CrudNetAngular.Core.DataContracts.Response;
using CrudNetAngular.Core.Interfaces.Repositories.UoW;
using CrudNetAngular.Core.Interfaces.Validates;
using CrudNetAngular.Core.Models;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace CrudNetAngular.Core.Services
{
    public class DeleteTalentBaseOperationHandler : BaseOperationHandler<DeleteTalentBaseRequest, TalentBaseResponse>
    {
        public DeleteTalentBaseOperationHandler(IUnitOfWork unitOfWork,
                                IBaseValidate<DeleteTalentBaseRequest> validate,
                                IMapper mapper,
                                ILogger logger) : base(unitOfWork, validate, mapper, logger)
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

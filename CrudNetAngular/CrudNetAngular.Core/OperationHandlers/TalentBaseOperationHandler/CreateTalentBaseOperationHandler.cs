using AutoMapper;
using CrudNetAngular.Core.DataContracts.Request.TalentBase;
using CrudNetAngular.Core.DataContracts.Response;
using CrudNetAngular.Core.Interfaces.Repositories.UoW;
using CrudNetAngular.Core.Interfaces.Validates;
using CrudNetAngular.Core.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace CrudNetAngular.Core.Services
{
    public class CreateTalentBaseOperationHandler : BaseOperationHandler<CreateTalentBaseRequest, TalentBaseResponse>
    {
        public CreateTalentBaseOperationHandler(IUnitOfWork unitOfWork,
                                IBaseValidate<CreateTalentBaseRequest> validate,
                                IMapper mapper,
                                ILogger logger) : base(unitOfWork, validate, mapper, logger)
        {

        }

        protected async override Task<TalentBaseResponse> ProcessAsync(CreateTalentBaseRequest request)
        {
            var talentBase = _mapper.Map<TalentBase>(request);
            await _unitOfWork.TalentBaseRepository.Add(talentBase);

            return _mapper.Map<TalentBaseResponse>(talentBase);
        }
    }
}

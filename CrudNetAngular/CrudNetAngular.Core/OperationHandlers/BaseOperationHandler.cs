using AutoMapper;
using CrudNetAngular.Core.Interfaces.Repositories.UoW;
using CrudNetAngular.Core.Interfaces.Validates;
using CrudNetAngular.DataContracts.Request;
using CrudNetAngular.DataContracts.Response;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CrudNetAngular.Core.Services
{
    public abstract class BaseOperationHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
        where TRequest : BaseRequest<TResponse>
        where TResponse : BaseResponse, new()
    {
        protected IUnitOfWork _unitOfWork;
        protected IBaseValidate<TRequest> _validate;
        protected IMapper _mapper;
        protected ILogger _logger;

        public BaseOperationHandler(IUnitOfWork unitOfWork, IBaseValidate<TRequest> validate, IMapper mapper, ILogger logger)
        {
            _unitOfWork = unitOfWork;
            _validate = validate;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken)
        {
            var response = new TResponse();
            try
            {
                _logger.LogTrace("Starting handle of request: {@request}", request);

                if (!isValid(request))
                {
                    return new TResponse()
                    {
                        Success = false,
                        Message = "Inválid request"
                    };
                }

                await _unitOfWork.BeginTransactionAsync();

                response = await ProcessAsync(request);

                await _unitOfWork.CommitTransactionAsync();

            }
            catch (Exception ex)
            {
                _unitOfWork.RollbackTransaction();
                _logger.LogError(ex.Message, ex.Data);
                return new TResponse()
                {
                    Success = false,
                    Message = ex.Message
                };
            }

            return response;
        }

        /// <summary>
        /// Processes the service. The implementation must define the processing logic.
        /// </summary>
        /// <param name="request"></param>
        /// <returns>The response. See <see cref="TResponse" /> for more information.</returns>
        protected abstract Task<TResponse> ProcessAsync(TRequest request);
        /// <summary>
        /// Override this method with custom validation logic if desired.
        /// </summary>
        /// <param name="request">The request object to be validated.</param>
        protected virtual bool isValid(TRequest request)
        {
            return _validate.IsValid(request);
        }
    }
}

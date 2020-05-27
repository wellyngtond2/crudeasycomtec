using CrudNetAngular.DataContracts.Response;
using MediatR;

namespace CrudNetAngular.DataContracts.Request
{
    /// <summary>
    /// Base of the contract request
    /// </summary>
    public abstract class BaseRequest<TResponse> : IRequest<TResponse> where TResponse : BaseResponse { }
}

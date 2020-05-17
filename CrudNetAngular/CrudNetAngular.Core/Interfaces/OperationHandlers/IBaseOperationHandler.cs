using CrudNetAngular.Core.DataContracts.Request;
using CrudNetAngular.Core.DataContracts.Response;
using System.Threading.Tasks;

namespace CrudNetAngular.Application.Interfaces
{
    public interface IBaseOperationHandler<TRequest, TResponse> 
        where TRequest : BaseRequest
        where TResponse : BaseResponse
    {
        Task<TResponse> Handle(TRequest request);
    }
}

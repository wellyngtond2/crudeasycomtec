using CrudNetAngular.DataContracts.Response;
using System;

namespace CrudNetAngular.DataContracts.Request
{
    public sealed class OccupationRequest : BaseRequest<BaseResponse>
    {
        /// <summary>
        /// Identify of occupation.
        /// </summary>
        public Guid Id { get; set; }
    }
}

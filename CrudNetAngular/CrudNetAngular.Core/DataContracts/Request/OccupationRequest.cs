using System;

namespace CrudNetAngular.Core.DataContracts.Request
{
    public sealed class OccupationRequest : BaseRequest
    {
        /// <summary>
        /// Identify of occupation.
        /// </summary>
        public Guid Id { get; set; }
    }
}

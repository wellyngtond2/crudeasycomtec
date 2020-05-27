using CrudNetAngular.DataContracts.Response;
using System;

namespace CrudNetAngular.DataContracts.Request
{
    public sealed class KnowledgeRequest : BaseRequest<BaseResponse>
    {
        /// <summary>
        /// Identify of knowledge.
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Level of Knowledge
        /// </summary>
        public int Level { get; set; }
    }
}

using System;

namespace CrudNetAngular.Core.DataContracts.Request
{
    public sealed class KnowledgeRequest : BaseRequest
    {
        /// <summary>
        /// Identify of knowledge.
        /// </summary>
        public Guid Id { get; set; }
    }
}

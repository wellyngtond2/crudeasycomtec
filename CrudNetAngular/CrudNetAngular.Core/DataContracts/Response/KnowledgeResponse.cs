namespace CrudNetAngular.Core.DataContracts.Response
{
    public sealed class KnowledgeResponse : BaseResponse
    {
        /// <summary>
        /// Identify of knowledge.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Description of knowledge.
        /// </summary>
        public string Description { get; set; }
    }
}

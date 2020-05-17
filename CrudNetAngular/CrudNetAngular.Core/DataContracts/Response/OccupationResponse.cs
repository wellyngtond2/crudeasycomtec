namespace CrudNetAngular.Core.DataContracts.Response
{
    public sealed class OccupationResponse : BaseResponse
    {
        /// <summary>
        /// Identify of occupation.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Description of occupation.
        /// </summary>
        public string Description { get; set; }
    }
}

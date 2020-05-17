using System;

namespace CrudNetAngular.Core.DataContracts.Request.TalentBase
{
    public sealed class DeleteTalentBaseRequest : BaseRequest
    {
        /// <summary>
        /// Identify of TalentBase.
        /// </summary>
        public Guid Id { get; set; }
    }
}

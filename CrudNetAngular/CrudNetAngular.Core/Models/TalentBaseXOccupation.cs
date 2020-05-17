using System.Collections.Generic;

namespace CrudNetAngular.Core.Models
{
    /// <summary>
    /// Record of talent base id and Occupation.
    /// </summary>
    public sealed class TalentBaseXOccupation : BaseModel
    {
        /// <summary>
        /// TalentBase.
        /// </summary>
        public TalentBase TalentBase { get; set; }
        /// <summary>
        /// Occupation.
        /// </summary>
        public Occupation Occupation { get; set; }
    }
}

using System.Collections.Generic;

namespace CrudNetAngular.Core.Models
{
    /// <summary>
    /// Record of talent base id and Knowledge.
    /// </summary>
    public sealed class TalentBaseXKnowledge : BaseModel
    {
        /// <summary>
        /// Level of knowledge.
        /// </summary>
        public int Level { get; set; }
        /// <summary>
        /// TalentBase.
        /// </summary>
        public TalentBase TalentBase { get; set; }
        /// <summary>
        /// Knowledge.
        /// </summary>
        public Knowledge Knowledge { get; set; }
    }
}

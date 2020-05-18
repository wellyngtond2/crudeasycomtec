using System;

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
        /// TalentBase identify
        /// </summary>
        public Guid TalentBaseId { get; set; }
        /// <summary>
        /// Knowledge.
        /// </summary>
        public Knowledge Knowledge { get; set; }
        /// <summary>
        /// Knowloedge identify
        /// </summary>
        public Guid KnowledgeId { get; set; }
    }
}

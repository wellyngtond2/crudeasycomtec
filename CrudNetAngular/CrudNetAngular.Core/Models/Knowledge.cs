using System.Collections.Generic;

namespace CrudNetAngular.Core.Models
{
    /// <summary>
    /// Knowledge of developer
    /// </summary>
    public sealed class Knowledge : BaseModel
    {
        /// <summary>
        /// Description of knowledge.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// List of TalentBaseXKnowledge.
        /// </summary>
        public ICollection<TalentBaseXKnowledge> TalentBaseXKnowledge { get; set; }
    }
}


using System.Collections.Generic;

namespace CrudNetAngular.Core.Models
{
    /// <summary>
    /// Occupation data of developer.
    /// </summary>
    public sealed class Occupation: BaseModel
    {
        /// <summary>
        /// Description of occupation.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// List of TalentBaseXOccupation.
        /// </summary>
        public ICollection<TalentBaseXOccupation> TalentBaseXOccupation { get; set; }
    }
}

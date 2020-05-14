using System.Collections.Generic;

namespace CrudNetAngular.Core.Models
{
    /// <summary>
    /// Record of talent base.
    /// </summary>
    public sealed class TalentBase : BaseModel
    {
        /// <summary>
        /// Other knowledge unlisted.
        /// </summary>
        public string KnowledgePlus { get; set; }
        /// <summary>
        /// Link of challenge crud.
        /// </summary>
        public string CrudLink { get; set; }
        /// <summary>
        /// Price of worked hour.
        /// </summary>
        public decimal HourPrice { get; set; }
        /// <summary>
        /// Candidate developer.
        /// </summary>
        public Developer Developer { get; set; }
        /// <summary>
        /// List of knowledge.
        /// </summary>
        public ICollection<Knowledge> Knowledges { get; set; }
        /// <summary>
        /// List of Occupation.
        /// </summary>
        public ICollection<Occupation> Occupations { get; set; }
    }
}

using System;

namespace CrudNetAngular.Core.Models
{
    /// <summary>
    /// Base of all entities.
    /// </summary>
    public abstract class BaseModel
    {
        /// <summary>
        /// Entity identify.
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Record creation Date.
        /// </summary>
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// Record update Date.
        /// </summary>
        public DateTime UpdatedAt { get; set; }
    }
}

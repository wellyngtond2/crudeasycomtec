using System.Collections.Generic;

namespace CrudNetAngular.DataContracts.Response
{
    public sealed class TalentBaseResponse : BaseResponse
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
        public DeveloperResponse Developer { get; set; }
        /// <summary>
        /// List of knowledge.
        /// </summary>
        public ICollection<KnowledgeResponse> Knowledges { get; set; }
        /// <summary>
        /// List of Occupation.
        /// </summary>
        public ICollection<OccupationResponse> Occupations { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CrudNetAngular.Core.DataContracts.Request.TalentBase
{
    public sealed class UpdateTalentBaseRequest : BaseRequest
    {
        /// <summary>
        /// Identify of TalentBase.
        /// </summary>
        public Guid Id { get; set; }
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
        [Required]
        public decimal HourPrice { get; set; }
        /// <summary>
        /// Candidate developer.
        /// </summary>
        [Required]
        public DeveloperRequest Developer { get; set; }
        /// <summary>
        /// List of knowledge.
        /// </summary>
        [Required]
        public ICollection<KnowledgeRequest> Knowledges { get; set; }
        /// <summary>
        /// List of Occupation.
        /// </summary>
        public ICollection<OccupationRequest> Occupations { get; set; }
    }
}

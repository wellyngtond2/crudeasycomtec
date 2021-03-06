﻿using CrudNetAngular.DataContracts.Response;
using System;

namespace CrudNetAngular.DataContracts.Request.TalentBase
{
    public sealed class GetTalentBaseRequest : BaseRequest<TalentBaseResponse>
    {
        /// <summary>
        /// Identify of TalentBase.
        /// </summary>
        public Guid Id { get; set; }
    }
}

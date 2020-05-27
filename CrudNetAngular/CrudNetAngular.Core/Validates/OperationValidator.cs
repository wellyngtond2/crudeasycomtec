using CrudNetAngular.Core.Interfaces.Validates;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrudNetAngular.Core.Validates
{
    public class OperationValidator<TRequest> : AbstractValidator<TRequest>, IBaseValidate<TRequest>
    {
        public bool IsValid(TRequest request)
        {
            return true;
        }
    }
}

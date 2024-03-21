using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.DomainModel.Validation
{
    public class ForbiddenFirstAttribute : ValidationAttribute
    {
        private readonly string _forbiddenFirstName;

        public ForbiddenFirstAttribute(string forbiddenFirstName)
        {
            _forbiddenFirstName = forbiddenFirstName;
        }
        public override bool IsValid(object? value)
        {
            return !value?.ToString()?.ToLower().Contains(_forbiddenFirstName) ?? false;
        }
    }
}

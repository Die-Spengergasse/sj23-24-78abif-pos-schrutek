using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.DomainModel.Validation
{
    public class ModelValidator<TEntity>
        where TEntity : class
    {
        public (bool, List<string>) Validate(TEntity entity)
        {
            bool isValid = true;
            List<string> errorList = new();

            PropertyInfo[] properties = entity.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                IEnumerable<Attribute> attr = property.GetCustomAttributes();
                foreach (Attribute attribute in attr)
                {
                    if (attribute?.GetType()?.BaseType?.Name != nameof(ValidationAttribute))
                    {
                        continue;
                    }
                    ValidationAttribute modelEntityValidator = (ValidationAttribute)attribute;
                    if (modelEntityValidator is null)
                    {
                        continue;
                    }
                    object? val = property.GetValue(entity);
                    isValid = modelEntityValidator.IsValid(val);
                    if (!isValid 
                        && !string.IsNullOrEmpty(modelEntityValidator.ErrorMessage))
                    {
                        errorList.Add(modelEntityValidator.ErrorMessage);
                    }
                }
            }
            return (isValid, errorList);
        }
    }
}

using Spg.CifBazar.DomainModel.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Spg.CifBazar.DomainModel.Model
{
    public class Product : IEntity
    {
        private Product()
        { }
        public Product(string name, string description, DateOnly expiryDate, Category categoryNavigation)
        {
            Name = name;
            Description = description;
            ExpiryDate = expiryDate;
            CategoryNavigation = categoryNavigation;
        }
        public Product(string name, string description, DateOnly expiryDate)
        {
            Name = name;
            Description = description;
            ExpiryDate = expiryDate;
        }

        [StringLength(maximumLength: 20, MinimumLength = 3, ErrorMessage = "Name muss zwischen 3 und 20 Zeichen lang sein!")]
        [ForbiddenFirst("homer", ErrorMessage = "Homers dürfen hier nicht rein!")]
        public string Name { get; set; } = string.Empty; // PK
        public Guid ProductNumber { get; set; }  // Produktnummer
        public string Description { get; set; } = string.Empty;
        public DateOnly ExpiryDate { get; set; }
        public Category? CategoryNavigation { get; set; } = default!;
    }
}

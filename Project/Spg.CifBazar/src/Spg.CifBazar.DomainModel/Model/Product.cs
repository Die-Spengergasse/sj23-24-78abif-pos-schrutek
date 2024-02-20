using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
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

        public string Name { get; set; } = string.Empty; // PK
        public string Description { get; set; } = string.Empty;
        public DateOnly ExpiryDate { get; set; }
        public Category? CategoryNavigation { get; set; } = default!;
    }
}

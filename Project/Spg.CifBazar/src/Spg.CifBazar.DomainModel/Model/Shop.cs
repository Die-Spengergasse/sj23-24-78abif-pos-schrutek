using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.DomainModel.Model
{
    public class Shop : IEntity
    {
        private Shop()
        { }
        public Shop(
            string name, 
            Address address, 
            PhoneNumber phoneNumber, 
            EMail eMail)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            EMail = eMail;
        }

        public Shop(
            string name,
            string? companySuffix,
            Address address,
            PhoneNumber phoneNumber,
            EMail eMail)
        {
            Name = name;
            CompanySuffix = companySuffix;
            Address = address;
            PhoneNumber = phoneNumber;
            EMail = eMail;
        }

        public int Id { get; private set; } // PK, auto increment, kommt von DB
        public string Name { get; set; } = string.Empty; // IsRequred
        public string? CompanySuffix { get; set; } // darf NULL sein

        public Address Address { get; set; } = default!;
        public PhoneNumber PhoneNumber { get; set; } = default!;
        public EMail EMail { get; set; } = default!;

        private List<Category> _categories = new();
        public IReadOnlyList<Category> Categories => _categories;

        public Shop AddCategory(Category category) 
        {
            if (category is not null)
            {
                // TODO: Diverse Checks
                category.ShopNavigation = this;
                _categories.Add(category);
            }
            return this;
        }

        public Shop RemoveCategory(Category category)
        {
            if (category is not null)
            {
                _categories.Remove(category);
            }
            return this;
        }

        public Shop AddCategories(IEnumerable<Category> categories)
        {
            //if (categories is not null)
            //{
            //    foreach (Category c in categories)
            //    {
            //        if (c is not null)
            //        {
            //            c.ShopNavigation = this;
            //            _categories.Add(c);
            //        }
            //    }
            //}

            _categories
                .AddRange(categories?
                    .Where(c => c is not null)
                    .OrderBy(c => c.Name)
                    .Select(c => new Category(c.Name, this))
                        ?? new List<Category>());

            return this;
        }
    }
}

using Bogus;
using Spg.CifBazar.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.Infrastructure
{
    public class InstantiationFactory
    {
        public static Shop GenerateShop(Faker f)
        {
            return new Shop(
                f.Company.CompanyName(),
                new Address(f.Address.StreetName(), f.Address.BuildingNumber(), f.Address.ZipCode(), f.Address.Country()),
                new PhoneNumber(f.Random.Int(1111, 9999).ToString(), f.Phone.PhoneNumber()),
                new EMail(f.Internet.Email()));
        }

        public static Category GenerateCategory(Faker f)
        {
            string[] categories = f.Commerce.Categories(100);
            return new Category(f.Random.ArrayElement(categories));
        }
    }
}

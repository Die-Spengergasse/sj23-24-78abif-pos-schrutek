using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.DomainModel.Model
{
    public record Address(string Street, string HouseNumber, string Zip, string Country)
    {
        public string GetFullAddress()
        {
            return $"{Street} {HouseNumber}, {Zip}-{Country}";
        }
    }

    // Value Object haben keine ID uÚND sind immer Immutable
    public class Address_Old
    {
        public Address_Old(string street, string houseNumber, string zip, string country)
        {
            Street = street;
            HouseNumber = houseNumber;
            Zip = zip;
            Country = country;
        }

        //public int Id { get; } // Value Objects haben keinen PK
        public string Street { get; } = string.Empty;
        public string HouseNumber { get; } = string.Empty;
        public string Zip { get; } = string.Empty;
        public string Country { get; } = string.Empty;
    }
}

using Spg.CifBazar.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.DomainModel.Dtos
{
    public record CreateShopCommand(
        string? Name, string?
        CompanySuffix,
        AddressDto Address,
        PhoneNumberDto PhoneNumber,
        EMailDto EMail);
}

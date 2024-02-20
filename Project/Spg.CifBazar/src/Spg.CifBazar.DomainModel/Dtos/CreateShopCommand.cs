using Spg.CifBazar.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.DomainModel.Dtos
{
    public class CreateShopCommand
    {
        public string? Name { get; set; } = string.Empty; // IsRequred
        public string? CompanySuffix { get; set; } // darf NULL sein

        public Address Address { get; set; } = default!;
        public PhoneNumber PhoneNumber { get; set; } = default!;
        public EMail EMail { get; set; } = default!;
    }
}

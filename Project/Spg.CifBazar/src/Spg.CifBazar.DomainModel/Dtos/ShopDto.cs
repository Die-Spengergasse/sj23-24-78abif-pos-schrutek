using Spg.CifBazar.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.DomainModel.Dtos
{
    public class ShopDto
    {
        public string? Name { get; set; } = string.Empty; // IsRequred
        public string? CompanySuffix { get; set; } // darf NULL sein
    }
}

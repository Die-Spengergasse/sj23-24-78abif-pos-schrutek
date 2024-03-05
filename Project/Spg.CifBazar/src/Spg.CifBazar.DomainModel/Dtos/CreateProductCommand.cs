using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.DomainModel.Dtos
{
    public record CreateProductCommand(string Name, string Description, DateTime ExpiryDate, int CategroyId);
}

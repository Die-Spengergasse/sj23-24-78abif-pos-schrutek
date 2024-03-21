using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.DomainModel.Dtos
{
    public record CreateProductCommand(
        [StringLength(maximumLength: 20, MinimumLength = 3, ErrorMessage = "Name muss eine Länge zwischen 3 und 20 Zeichen haben!")]
        string Name,
        string Description, 
        DateTime ExpiryDate, 
        int CategroyId);
}
